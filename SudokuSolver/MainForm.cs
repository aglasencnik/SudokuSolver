namespace SudokuSolver
{
    public partial class MainForm : Form
    {
        #region Decleration of variables

        private int numOfInputs;
        private bool tbx_1_used;
        private bool tbx_2_used;
        private bool tbx_3_used;
        private bool tbx_4_used;
        private bool tbx_5_used;
        private bool tbx_6_used;
        private bool tbx_7_used;
        private bool tbx_8_used;
        private bool tbx_9_used;
        private bool tbx_10_used;
        private bool tbx_11_used;
        private bool tbx_12_used;
        private bool tbx_13_used;
        private bool tbx_14_used;
        private bool tbx_15_used;
        private bool tbx_16_used;
        private bool tbx_17_used;
        private bool tbx_18_used;
        private bool tbx_19_used;
        private bool tbx_20_used;
        private bool tbx_21_used;
        private bool tbx_22_used;
        private bool tbx_23_used;
        private bool tbx_24_used;
        private bool tbx_25_used;
        private bool tbx_26_used;
        private bool tbx_27_used;
        private bool tbx_28_used;
        private bool tbx_29_used;
        private bool tbx_30_used;
        private bool tbx_31_used;
        private bool tbx_32_used;
        private bool tbx_33_used;
        private bool tbx_34_used;
        private bool tbx_35_used;
        private bool tbx_36_used;
        private bool tbx_37_used;
        private bool tbx_38_used;
        private bool tbx_39_used;
        private bool tbx_40_used;
        private bool tbx_41_used;
        private bool tbx_42_used;
        private bool tbx_43_used;
        private bool tbx_44_used;
        private bool tbx_45_used;
        private bool tbx_46_used;
        private bool tbx_47_used;
        private bool tbx_48_used;
        private bool tbx_49_used;
        private bool tbx_50_used;
        private bool tbx_51_used;
        private bool tbx_52_used;
        private bool tbx_53_used;
        private bool tbx_54_used;
        private bool tbx_55_used;
        private bool tbx_56_used;
        private bool tbx_57_used;
        private bool tbx_58_used;
        private bool tbx_59_used;
        private bool tbx_60_used;
        private bool tbx_61_used;
        private bool tbx_62_used;
        private bool tbx_63_used;
        private bool tbx_64_used;
        private bool tbx_65_used;
        private bool tbx_66_used;
        private bool tbx_67_used;
        private bool tbx_68_used;
        private bool tbx_69_used;
        private bool tbx_70_used;
        private bool tbx_71_used;
        private bool tbx_72_used;
        private bool tbx_73_used;
        private bool tbx_74_used;
        private bool tbx_75_used;
        private bool tbx_76_used;
        private bool tbx_77_used;
        private bool tbx_78_used;
        private bool tbx_79_used;
        private bool tbx_80_used;
        private bool tbx_81_used;

        #endregion


        public MainForm()
        {
            try
            {
                InitializeComponent();
                resetCtor();
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void resetCtor()
        {
            try
            {
                numOfInputs = 0;
                tbx_1_used = false;
                tbx_2_used = false;
                tbx_3_used = false;
                tbx_4_used = false;
                tbx_5_used = false;
                tbx_6_used = false;
                tbx_7_used = false;
                tbx_8_used = false;
                tbx_9_used = false;
                tbx_10_used = false;
                tbx_11_used = false;
                tbx_12_used = false;
                tbx_13_used = false;
                tbx_14_used = false;
                tbx_15_used = false;
                tbx_16_used = false;
                tbx_17_used = false;
                tbx_18_used = false;
                tbx_19_used = false;
                tbx_20_used = false;
                tbx_21_used = false;
                tbx_22_used = false;
                tbx_23_used = false;
                tbx_24_used = false;
                tbx_25_used = false;
                tbx_26_used = false;
                tbx_27_used = false;
                tbx_28_used = false;
                tbx_29_used = false;
                tbx_30_used = false;
                tbx_31_used = false;
                tbx_32_used = false;
                tbx_33_used = false;
                tbx_34_used = false;
                tbx_35_used = false;
                tbx_36_used = false;
                tbx_37_used = false;
                tbx_38_used = false;
                tbx_39_used = false;
                tbx_40_used = false;
                tbx_41_used = false;
                tbx_42_used = false;
                tbx_43_used = false;
                tbx_44_used = false;
                tbx_45_used = false;
                tbx_46_used = false;
                tbx_47_used = false;
                tbx_48_used = false;
                tbx_49_used = false;
                tbx_50_used = false;
                tbx_51_used = false;
                tbx_52_used = false;
                tbx_53_used = false;
                tbx_54_used = false;
                tbx_55_used = false;
                tbx_56_used = false;
                tbx_57_used = false;
                tbx_58_used = false;
                tbx_59_used = false;
                tbx_60_used = false;
                tbx_61_used = false;
                tbx_62_used = false;
                tbx_63_used = false;
                tbx_64_used = false;
                tbx_65_used = false;
                tbx_66_used = false;
                tbx_67_used = false;
                tbx_68_used = false;
                tbx_69_used = false;
                tbx_70_used = false;
                tbx_71_used = false;
                tbx_72_used = false;
                tbx_73_used = false;
                tbx_74_used = false;
                tbx_75_used = false;
                tbx_76_used = false;
                tbx_77_used = false;
                tbx_78_used = false;
                tbx_79_used = false;
                tbx_80_used = false;
                tbx_81_used = false;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                resetLoad();
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void resetLoad()
        {
            try
            {
                btn_previous.Enabled = false;
                btn_next.Enabled = false;
                btn_previous.Visible = false;
                btn_next.Visible = false;
                lbl_numText.Visible = false;
                lbl_numOfResults.Visible = false;
                lbl_labelResultPage.Visible = false;
                lbl_currentPage.Visible = false;
                this.ActiveControl = lbl_version;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void errorHandler(Exception ex)
        {
            try
            {
                if (MessageBox.Show("The application has encountered an unexpected error!" + Environment.NewLine + "Do you want to see more details?", "Error!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Amadej Glasenènik, 2022" + Environment.NewLine + "aglasencnik.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        #region TextBox KeyPress methods
        //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void tbx_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_6_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_7_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_8_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_10_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_11_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_12_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_13_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_14_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_15_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_16_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_17_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_18_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_19_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_20_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_21_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_22_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_23_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_24_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_25_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_26_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_27_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_28_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_29_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_30_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_31_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_32_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_33_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_34_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_35_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_36_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_37_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_38_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_39_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_40_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_41_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_42_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_43_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_44_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_45_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_46_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_47_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_48_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_49_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_50_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_51_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_52_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_53_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_54_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_55_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_56_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_57_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_58_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_59_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_60_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_61_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_62_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_63_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_64_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_65_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_66_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_67_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_68_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_69_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_70_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_71_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_72_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_73_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_74_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_75_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_76_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_77_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_78_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_79_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_80_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_81_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }




        #endregion

        private void btn_solve_Click(object sender, EventArgs e)
        {
            try
            {
                if (numOfInputs >= 10)
                {
                    MessageBox.Show("More");
                }
                else
                {
                    MessageBox.Show("Less");
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                resetCtor();
                resetLoad();
                btn_solve.Enabled = true;
                lbl_numOfResults.Text = "";
                lbl_currentPage.Text = "";
                tbx_1.Enabled = true;
                tbx_2.Enabled = true;
                tbx_3.Enabled = true;
                tbx_4.Enabled = true;
                tbx_5.Enabled = true;
                tbx_6.Enabled = true;
                tbx_7.Enabled = true;
                //TODO
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        #region TextBox TextChanged methods for number of inputs

        private void tbx_1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_1.Text != "" && tbx_1.Text != "0")
                {
                    tbx_1_used = true;
                    numOfInputs++;
                }
                else if (tbx_1.Text == "" || tbx_1.Text == "0" && tbx_1_used == true)
                {
                    tbx_1_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_2.Text != "" && tbx_2.Text != "0")
                {
                    tbx_2_used = true;
                    numOfInputs++;
                }
                else if (tbx_2.Text == "" || tbx_2.Text == "0" && tbx_2_used == true)
                {
                    tbx_2_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_3.Text != "" && tbx_3.Text != "0")
                {
                    tbx_3_used = true;
                    numOfInputs++;
                }
                else if (tbx_3.Text == "" || tbx_3.Text == "0" && tbx_3_used == true)
                {
                    tbx_3_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_4.Text != "" && tbx_4.Text != "0")
                {
                    tbx_4_used = true;
                    numOfInputs++;
                }
                else if (tbx_4.Text == "" || tbx_4.Text == "0" && tbx_4_used == true)
                {
                    tbx_4_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_5.Text != "" && tbx_5.Text != "0")
                {
                    tbx_5_used = true;
                    numOfInputs++;
                }
                else if (tbx_5.Text == "" || tbx_5.Text == "0" && tbx_5_used == true)
                {
                    tbx_5_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_6.Text != "" && tbx_6.Text != "0")
                {
                    tbx_6_used = true;
                    numOfInputs++;
                }
                else if (tbx_6.Text == "" || tbx_6.Text == "0" && tbx_6_used == true)
                {
                    tbx_6_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_7.Text != "" && tbx_7.Text != "0")
                {
                    tbx_7_used = true;
                    numOfInputs++;
                }
                else if (tbx_7.Text == "" || tbx_7.Text == "0" && tbx_7_used == true)
                {
                    tbx_7_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_8.Text != "" && tbx_8.Text != "0")
                {
                    tbx_8_used = true;
                    numOfInputs++;
                }
                else if (tbx_8.Text == "" || tbx_8.Text == "0" && tbx_8_used == true)
                {
                    tbx_8_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_9.Text != "" && tbx_9.Text != "0")
                {
                    tbx_9_used = true;
                    numOfInputs++;
                }
                else if (tbx_9.Text == "" || tbx_9.Text == "0" && tbx_9_used == true)
                {
                    tbx_9_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_10.Text != "" && tbx_10.Text != "0")
                {
                    tbx_10_used = true;
                    numOfInputs++;
                }
                else if (tbx_10.Text == "" || tbx_10.Text == "0" && tbx_10_used == true)
                {
                    tbx_10_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_11.Text != "" && tbx_11.Text != "0")
                {
                    tbx_11_used = true;
                    numOfInputs++;
                }
                else if (tbx_11.Text == "" || tbx_11.Text == "0" && tbx_11_used == true)
                {
                    tbx_11_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_12.Text != "" && tbx_12.Text != "0")
                {
                    tbx_12_used = true;
                    numOfInputs++;
                }
                else if (tbx_12.Text == "" || tbx_12.Text == "0" && tbx_12_used == true)
                {
                    tbx_12_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_13.Text != "" && tbx_13.Text != "0")
                {
                    tbx_13_used = true;
                    numOfInputs++;
                }
                else if (tbx_13.Text == "" || tbx_13.Text == "0" && tbx_13_used == true)
                {
                    tbx_13_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_14.Text != "" && tbx_14.Text != "0")
                {
                    tbx_14_used = true;
                    numOfInputs++;
                }
                else if (tbx_14.Text == "" || tbx_14.Text == "0" && tbx_14_used == true)
                {
                    tbx_14_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_15.Text != "" && tbx_15.Text != "0")
                {
                    tbx_15_used = true;
                    numOfInputs++;
                }
                else if (tbx_15.Text == "" || tbx_15.Text == "0" && tbx_15_used == true)
                {
                    tbx_15_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_16.Text != "" && tbx_16.Text != "0")
                {
                    tbx_16_used = true;
                    numOfInputs++;
                }
                else if (tbx_16.Text == "" || tbx_16.Text == "0" && tbx_16_used == true)
                {
                    tbx_16_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_17.Text != "" && tbx_17.Text != "0")
                {
                    tbx_17_used = true;
                    numOfInputs++;
                }
                else if (tbx_17.Text == "" || tbx_17.Text == "0" && tbx_17_used == true)
                {
                    tbx_17_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_18.Text != "" && tbx_18.Text != "0")
                {
                    tbx_18_used = true;
                    numOfInputs++;
                }
                else if (tbx_18.Text == "" || tbx_18.Text == "0" && tbx_18_used == true)
                {
                    tbx_18_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_19.Text != "" && tbx_19.Text != "0")
                {
                    tbx_19_used = true;
                    numOfInputs++;
                }
                else if (tbx_19.Text == "" || tbx_19.Text == "0" && tbx_19_used == true)
                {
                    tbx_19_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_20.Text != "" && tbx_20.Text != "0")
                {
                    tbx_20_used = true;
                    numOfInputs++;
                }
                else if (tbx_20.Text == "" || tbx_20.Text == "0" && tbx_20_used == true)
                {
                    tbx_20_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_21_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_21.Text != "" && tbx_21.Text != "0")
                {
                    tbx_21_used = true;
                    numOfInputs++;
                }
                else if (tbx_21.Text == "" || tbx_21.Text == "0" && tbx_21_used == true)
                {
                    tbx_21_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_22.Text != "" && tbx_22.Text != "0")
                {
                    tbx_22_used = true;
                    numOfInputs++;
                }
                else if (tbx_22.Text == "" || tbx_22.Text == "0" && tbx_22_used == true)
                {
                    tbx_22_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_23_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_23.Text != "" && tbx_23.Text != "0")
                {
                    tbx_23_used = true;
                    numOfInputs++;
                }
                else if (tbx_23.Text == "" || tbx_23.Text == "0" && tbx_23_used == true)
                {
                    tbx_23_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_24_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_24.Text != "" && tbx_24.Text != "0")
                {
                    tbx_24_used = true;
                    numOfInputs++;
                }
                else if (tbx_24.Text == "" || tbx_24.Text == "0" && tbx_24_used == true)
                {
                    tbx_24_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_25_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_25.Text != "" && tbx_25.Text != "0")
                {
                    tbx_25_used = true;
                    numOfInputs++;
                }
                else if (tbx_25.Text == "" || tbx_25.Text == "0" && tbx_25_used == true)
                {
                    tbx_25_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_26_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_26.Text != "" && tbx_26.Text != "0")
                {
                    tbx_26_used = true;
                    numOfInputs++;
                }
                else if (tbx_26.Text == "" || tbx_26.Text == "0" && tbx_26_used == true)
                {
                    tbx_26_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_27.Text != "" && tbx_27.Text != "0")
                {
                    tbx_27_used = true;
                    numOfInputs++;
                }
                else if (tbx_27.Text == "" || tbx_27.Text == "0" && tbx_27_used == true)
                {
                    tbx_27_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_28_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_28.Text != "" && tbx_28.Text != "0")
                {
                    tbx_28_used = true;
                    numOfInputs++;
                }
                else if (tbx_28.Text == "" || tbx_28.Text == "0" && tbx_28_used == true)
                {
                    tbx_28_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_29_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_29.Text != "" && tbx_29.Text != "0")
                {
                    tbx_29_used = true;
                    numOfInputs++;
                }
                else if (tbx_29.Text == "" || tbx_29.Text == "0" && tbx_29_used == true)
                {
                    tbx_29_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_30.Text != "" && tbx_30.Text != "0")
                {
                    tbx_30_used = true;
                    numOfInputs++;
                }
                else if (tbx_30.Text == "" || tbx_30.Text == "0" && tbx_30_used == true)
                {
                    tbx_30_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_31_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_31.Text != "" && tbx_31.Text != "0")
                {
                    tbx_31_used = true;
                    numOfInputs++;
                }
                else if (tbx_31.Text == "" || tbx_31.Text == "0" && tbx_31_used == true)
                {
                    tbx_31_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_32_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_32.Text != "" && tbx_32.Text != "0")
                {
                    tbx_32_used = true;
                    numOfInputs++;
                }
                else if (tbx_32.Text == "" || tbx_32.Text == "0" && tbx_32_used == true)
                {
                    tbx_32_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_33_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_33.Text != "" && tbx_33.Text != "0")
                {
                    tbx_33_used = true;
                    numOfInputs++;
                }
                else if (tbx_33.Text == "" || tbx_33.Text == "0" && tbx_33_used == true)
                {
                    tbx_33_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_34_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_34.Text != "" && tbx_34.Text != "0")
                {
                    tbx_34_used = true;
                    numOfInputs++;
                }
                else if (tbx_34.Text == "" || tbx_34.Text == "0" && tbx_34_used == true)
                {
                    tbx_34_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_35_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_35.Text != "" && tbx_35.Text != "0")
                {
                    tbx_35_used = true;
                    numOfInputs++;
                }
                else if (tbx_35.Text == "" || tbx_35.Text == "0" && tbx_35_used == true)
                {
                    tbx_35_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_36_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_36.Text != "" && tbx_36.Text != "0")
                {
                    tbx_36_used = true;
                    numOfInputs++;
                }
                else if (tbx_36.Text == "" || tbx_36.Text == "0" && tbx_36_used == true)
                {
                    tbx_36_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_37_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_37.Text != "" && tbx_37.Text != "0")
                {
                    tbx_37_used = true;
                    numOfInputs++;
                }
                else if (tbx_37.Text == "" || tbx_37.Text == "0" && tbx_37_used == true)
                {
                    tbx_37_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_38_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_38.Text != "" && tbx_38.Text != "0")
                {
                    tbx_38_used = true;
                    numOfInputs++;
                }
                else if (tbx_38.Text == "" || tbx_38.Text == "0" && tbx_38_used == true)
                {
                    tbx_38_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_39_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_39.Text != "" && tbx_39.Text != "0")
                {
                    tbx_39_used = true;
                    numOfInputs++;
                }
                else if (tbx_39.Text == "" || tbx_39.Text == "0" && tbx_39_used == true)
                {
                    tbx_39_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_40_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_40.Text != "" && tbx_40.Text != "0")
                {
                    tbx_40_used = true;
                    numOfInputs++;
                }
                else if (tbx_40.Text == "" || tbx_40.Text == "0" && tbx_40_used == true)
                {
                    tbx_40_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_41_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_41.Text != "" && tbx_41.Text != "0")
                {
                    tbx_41_used = true;
                    numOfInputs++;
                }
                else if (tbx_41.Text == "" || tbx_41.Text == "0" && tbx_41_used == true)
                {
                    tbx_41_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_42_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_42.Text != "" && tbx_42.Text != "0")
                {
                    tbx_42_used = true;
                    numOfInputs++;
                }
                else if (tbx_42.Text == "" || tbx_42.Text == "0" && tbx_42_used == true)
                {
                    tbx_42_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_43_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_43.Text != "" && tbx_43.Text != "0")
                {
                    tbx_43_used = true;
                    numOfInputs++;
                }
                else if (tbx_43.Text == "" || tbx_43.Text == "0" && tbx_43_used == true)
                {
                    tbx_43_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_44_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_44.Text != "" && tbx_44.Text != "0")
                {
                    tbx_44_used = true;
                    numOfInputs++;
                }
                else if (tbx_44.Text == "" || tbx_44.Text == "0" && tbx_44_used == true)
                {
                    tbx_44_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_45_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_46_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_47_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_48_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_49_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_50_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_51_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_52_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_53_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_54_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_55_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_56_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_57_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_58_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_59_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_60_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_61_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_62_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_63_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_64_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_65_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_66_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_67_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_68_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_69_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_70_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_71_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_72_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_73_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_74_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_75_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_76_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_77_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_78_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_79_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_80_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_81_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        
    }
}