using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BACKUP_RESTORE
{
    public partial class Form_Main : Form
    {
        private String tenDevice;
        private int banSaoLuu = 0;
        Boolean thoat = false;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTMDataSet.DATABASES' table. You can move, or remove it, as needed.
            this.TableAdapter_databases.Connection.ConnectionString = Program.connstr;
            this.TableAdapter_databases.Fill(this.DS_LTM.DATABASES);

            label_ngaygio.Visible = dateEdit_restore.Visible = timeEdit_restore.Visible = richTextBox_mota.Visible = false;
            button_xoasaoluu.Visible = false;

        }

        private void barButtonItem_saoluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Label_tenCSDL.Text.Trim() == "" || tenDevice == "") return;
            String strBackup = "BACKUP DATABASE " + Label_tenCSDL.Text.Trim() + " TO " + tenDevice;
            if (checkBox_xoatatca.Checked == true)
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa các bản sao lưu cũ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    strBackup = strBackup + " WITH INIT";
                else return;
            int err = Program.ExecSqlNonQuery(strBackup, Program.connstr, "");
            if (err != 0)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu " + Label_tenCSDL.Text.Trim());
                return;
            }


            checkBox_xoatatca.Checked = false;
            MessageBox.Show("Đã sao lưu cơ sở dữ liệu!");
            //reload lại các bản sao lưu
            LoadCacBanSaoLuu();
        }

        private void barButtonItem_phuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strRestore;

            if (this.BDS_SP_STT_BACKUP.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (banSaoLuu == 0)
            {
                MessageBox.Show("Chưa chọn một bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close(); // đóng kết nối

            if (Label_tenCSDL.Text.Trim() == "" || tenDevice == "") return;
            strRestore = "ALTER DATABASE " + Label_tenCSDL.Text.Trim()
                    + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                    "USE tempdb \n";


            // Phục hồi về một thời điểm đã sao lưu
            if (barCheckItem_phuchoitheotg.Checked == false)
            {
                strRestore += "RESTORE DATABASE " + Label_tenCSDL.Text.Trim()
                    + " FROM " + tenDevice + " WITH FILE =  " + banSaoLuu + ", REPLACE "
                    + "ALTER DATABASE  " + Label_tenCSDL.Text.Trim() + " SET MULTI_USER";

                if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi database " + Label_tenCSDL.Text.Trim() + " về file " + banSaoLuu + "?"
                  , "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi cơ sở dữ liệu.");
                    if (err == 0)
                    {
                        MessageBox.Show("Phục hồi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else return;
                }
                else return;
            }
            //phục hồi về thời điểm bất kỳ do người dùng nhập
            else
            {
                // Ngày giờ phục hồi phải > thời điểm sao lưu và nhỏ hơn thời điểm hiện tại ít nhất 3p\
                // Ngày giờ của bản backup được chọn
                DateTime ngaygioBK = (DateTime)((DataRowView)BDS_SP_STT_BACKUP[BDS_SP_STT_BACKUP.Position])["backup_start_date"];

                // ngày giờ muốn phục hồi của user
                String strThoiDiemRestore = dateEdit_restore.DateTime.Year + "-" + dateEdit_restore.DateTime.Month + "-" + dateEdit_restore.DateTime.Day + " " +
                    timeEdit_restore.Time.Hour + ":" + timeEdit_restore.Time.Minute + ":" + timeEdit_restore.Time.Second;

                try
                {
                    //// trường hợp h:m:s bằng nhưng còn phần ms  dương
                    // format Ngày giờ người dùng nhập
                    DateTime thoiDiemRestore = DateTime.Parse(strThoiDiemRestore);
                   //thoiDiemRestore.ToString("yyyy’-‘MM’-‘dd’ ’HH’:’mm’:’ss");

                    // Kiểm tra sau thời điểm hiện tại
                    if (thoiDiemRestore > DateTime.Now)
                    {
                        MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại", "", MessageBoxButtons.OK);
                        //progressBar.Visible = false;
                        return;
                    }

                    //if (dateEdit_restore.DateTime.Date <= ngaygioBK.Date
                    //    || thoiDiemRestore.TimeOfDay.Ticks < ngaygioBK.TimeOfDay.Ticks)
                    if (DateTime.Compare(thoiDiemRestore, ngaygioBK) <= 0)
                    {
                        MessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản sao lưu đã chọn", "", MessageBoxButtons.OK);
                        //progressBar.Visible = false;
                        return;
                    }

                    if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi database " + Label_tenCSDL.Text.Trim() + " về ngày " + thoiDiemRestore.ToString("yyyy-MM-dd HH:mm:ss") + "?"
                    , "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        try
                        {
                            // Restore CSDL với NORECOVERY
                            // Restore về 1 thời điểm người dùng nhập
                            strRestore += "BACKUP LOG " + Label_tenCSDL.Text.Trim() + " TO DISK = '" + Program.defaultPath + "DEVICE_" + Label_tenCSDL.Text.Trim() + ".trn' WITH INIT, NORECOVERY; \n" +
                                    "USE tempdb \n" +
                                    "RESTORE DATABASE " + Label_tenCSDL.Text.Trim() + " FROM DISK = '" + Program.defaultPath + "DEVICE_" + Label_tenCSDL.Text.Trim() + ".bak' WITH NORECOVERY; \n" +
                                    "RESTORE DATABASE " + Label_tenCSDL.Text.Trim() + " FROM DISK = '" + Program.defaultPath + "DEVICE_" + Label_tenCSDL.Text.Trim() + ".trn' " +
                                    "WITH STOPAT= '" + thoiDiemRestore.ToString("yyyy-MM-dd HH:mm:ss") + "' \n" +
                                    "ALTER DATABASE  " + Label_tenCSDL.Text.Trim() + " SET MULTI_USER ";
                            MessageBox.Show(strRestore);
                            int err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi Phục hồi CSDL với NORECOVERY . Bạn thực hiện lại lệnh.  ");
                            if (err == 0)
                            {
                                MessageBox.Show("Phục hồi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                strRestore = " RESTORE DATABASE " + Label_tenCSDL.Text.Trim() + " FROM " + tenDevice + " WITH FILE=" + banSaoLuu +
                                     " ALTER DATABASE " + Label_tenCSDL.Text.Trim() + "  SET MULTI_USER ";
                                Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                                return;
                            }


                            // Restore từ file log
                            //strRestore = //"USE TEMPDB SET DATEFORMAT DMY  " +
                            //    " RESTORE DATABASE " + Label_tenCSDL.Text.Trim() + " FROM DISK = '" + Program.defaultPath + "DEVICE_" + Label_tenCSDL.Text.Trim() + ".trn' " +
                            //         " WITH STOPAT=N'" + thoiDiemRestore;//+ "' , RECOVERY    ";
                            //err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi Phục hồi CSDL TỪ FILE LOG.");
                            //if (err == 0)
                            //{
                            //    strRestore = " ALTER DATABASE " + Label_tenCSDL.Text.Trim() + "  SET MULTI_USER ";
                            //    Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                            //}
                            //else
                            //{
                            //    strRestore = "   RESTORE DATABASE " + Label_tenCSDL.Text.Trim() + " FROM " + tenDevice + " WITH FILE=" + banSaoLuu +
                            //                  " ALTER DATABASE " + Label_tenCSDL.Text.Trim() + "  SET MULTI_USER ";
                            //    Program.ExecSqlNonQuery(strRestore, Program.connstr, "");
                            //    return;
                            //}
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi Restore:\n" + ex, "Xảy ra lỗi", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        //progressBar.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển đổi ngày" + ex.Message, "", MessageBoxButtons.OK);
                    
                }
            }
        }

        private void barCheckItem_phuchoitheotg_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(barCheckItem_phuchoitheotg.Checked == true)
            {
                label_ngaygio.Visible = dateEdit_restore.Visible = timeEdit_restore.Visible = richTextBox_mota.Visible = true;
            }
            else
            {
                label_ngaygio.Visible = dateEdit_restore.Visible = timeEdit_restore.Visible = richTextBox_mota.Visible = false;
            }
        }

        private void barButtonItem_taodevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Check folder default
            // if exist 
            if (Directory.Exists(Program.defaultPath) == true)
            {
                // Lưu trên disk
                String strTaoDevice = "EXEC sp_addumpdevice 'disk', 'DEVICE_" + Label_tenCSDL.Text.Trim() + "', " +
                    "'" + Program.defaultPath + "DEVICE_" + Label_tenCSDL.Text.Trim() + ".bak' ";

                int err = Program.ExecSqlNonQuery(strTaoDevice, Program.connstr, "Lỗi tạo device.");
                if (err == 0)
                {
                    // Show message diaglog create device successfull
                    MessageBox.Show("Tạo device thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tạo device thất bại!", "Xảy ra lỗi!", MessageBoxButtons.OK);
                    return;
                }

            }
            // Nếu không tồn tại --> cho phép user chọn đường dẫn để tạo devices
            else
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                // Always default to Folder Selection.
                folderBrowser.FileName = "Folder Selection.";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                    Program.defaultPath = folderPath + "\\";


                    // Lưu trên disk
                    String strTaoDevice = "EXEC sp_addumpdevice 'disk', 'DEVICE_" + Label_tenCSDL.Text.Trim() + "', " +
                        "'" + Program.defaultPath + "DEVICE_" + Label_tenCSDL.Text.Trim() + ".bak' ";

                    int err = Program.ExecSqlNonQuery(strTaoDevice, Program.connstr, "Lỗi tạo device.");
                    if (err == 0)
                    {
                        // Show message diaglog create device successfull
                        MessageBox.Show("Tạo device thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Tạo device thất bại!", "Xảy ra lỗi!", MessageBoxButtons.OK);
                        return;
                    }
                }

            }
        }

        private void barButtonItem_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!thoat)
            {
                if (XtraMessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    thoat = true;
                    Program.frmChinh.Close();
                    Program.loginForm.Visible = true;
                }
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!thoat)
            {
                if (XtraMessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    this.Dispose();
                    Program.loginForm.Visible = true;
                }
            }
        }

        private void Check_Device_Exist()
        {
            String strLenh = "select  COUNT(name) from  sys.backup_devices WHERE name = N'DEVICE_" + Label_tenCSDL.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);

            if (Program.myReader == null) return;

            Program.myReader.Read();

            if (Program.myReader.GetInt32(0) > 0)
            {
                barButtonItem_taodevice.Enabled = false;
                button_xoasaoluu.Visible = true;
                if (BDS_SP_STT_BACKUP.Count == 0) button_xoasaoluu.Enabled = false;
                tenDevice = "DEVICE_" + Label_tenCSDL.Text.Trim();
            }
            else
            {
                button_xoasaoluu.Visible = false;
                barButtonItem_taodevice.Enabled = true;
            }
        }

        private void GridControl_databases_Click(object sender, EventArgs e)
        {
            Program.databasename = ((DataRowView)this.BDS_DATABASES.Current).Row["name"].ToString();
            this.TableAdapter_SP_STT_BACKUP.Fill(this.DS_LTM.SP_STT_BACKUP, Label_tenCSDL.Text.Trim());
            Label_tenCSDL.Text = Label_tenCSDL.Text.Trim();

            if (BDS_SP_STT_BACKUP.Count == 0) banSaoLuu = 0;
            else banSaoLuu = int.Parse(((DataRowView)BDS_SP_STT_BACKUP[0])["position"].ToString());
            TextBox_stt.Text = banSaoLuu.ToString();

            Check_Device_Exist();
        }

        private void LoadCacBanSaoLuu()
        {
            if (Label_tenCSDL.Text.Trim() == "") return;
            try
            {
                Program.databasename = ((DataRowView)this.BDS_DATABASES.Current).Row["name"].ToString();
                this.TableAdapter_SP_STT_BACKUP.Connection.ConnectionString = Program.connstr;
                this.TableAdapter_SP_STT_BACKUP.Fill(this.DS_LTM.SP_STT_BACKUP, Label_tenCSDL.Text.Trim());
                Label_tenCSDL.Text = Label_tenCSDL.Text.Trim();

                if (BDS_SP_STT_BACKUP.Count == 0) banSaoLuu = 0;
                else banSaoLuu = int.Parse(((DataRowView)BDS_SP_STT_BACKUP[0])["position"].ToString());

                TextBox_stt.Text = banSaoLuu.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button_xoasaoluu_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa backup này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               
            }
            if (BDS_SP_STT_BACKUP.Count == 0) button_xoasaoluu.Enabled = false;
            LoadCacBanSaoLuu();
        }

        private void SP_STT_BACKUPGridControl_Click(object sender, EventArgs e)
        {
            banSaoLuu = int.Parse(TextBox_stt.Text.Trim());
            button_xoasaoluu.Visible = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();
        }
    }
}
