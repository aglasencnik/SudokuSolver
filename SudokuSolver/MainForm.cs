using System.Collections;

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

        private int tbx_1_number;
        private int tbx_2_number;
        private int tbx_3_number;
        private int tbx_4_number;
        private int tbx_5_number;
        private int tbx_6_number;
        private int tbx_7_number;
        private int tbx_8_number;
        private int tbx_9_number;
        private int tbx_10_number;
        private int tbx_11_number;
        private int tbx_12_number;
        private int tbx_13_number;
        private int tbx_14_number;
        private int tbx_15_number;
        private int tbx_16_number;
        private int tbx_17_number;
        private int tbx_18_number;
        private int tbx_19_number;
        private int tbx_20_number;
        private int tbx_21_number;
        private int tbx_22_number;
        private int tbx_23_number;
        private int tbx_24_number;
        private int tbx_25_number;
        private int tbx_26_number;
        private int tbx_27_number;
        private int tbx_28_number;
        private int tbx_29_number;
        private int tbx_30_number;
        private int tbx_31_number;
        private int tbx_32_number;
        private int tbx_33_number;
        private int tbx_34_number;
        private int tbx_35_number;
        private int tbx_36_number;
        private int tbx_37_number;
        private int tbx_38_number;
        private int tbx_39_number;
        private int tbx_40_number;
        private int tbx_41_number;
        private int tbx_42_number;
        private int tbx_43_number;
        private int tbx_44_number;
        private int tbx_45_number;
        private int tbx_46_number;
        private int tbx_47_number;
        private int tbx_48_number;
        private int tbx_49_number;
        private int tbx_50_number;
        private int tbx_51_number;
        private int tbx_52_number;
        private int tbx_53_number;
        private int tbx_54_number;
        private int tbx_55_number;
        private int tbx_56_number;
        private int tbx_57_number;
        private int tbx_58_number;
        private int tbx_59_number;
        private int tbx_60_number;
        private int tbx_61_number;
        private int tbx_62_number;
        private int tbx_63_number;
        private int tbx_64_number;
        private int tbx_65_number;
        private int tbx_66_number;
        private int tbx_67_number;
        private int tbx_68_number;
        private int tbx_69_number;
        private int tbx_70_number;
        private int tbx_71_number;
        private int tbx_72_number;
        private int tbx_73_number;
        private int tbx_74_number;
        private int tbx_75_number;
        private int tbx_76_number;
        private int tbx_77_number;
        private int tbx_78_number;
        private int tbx_79_number;
        private int tbx_80_number;
        private int tbx_81_number;

        ArrayList resultList;

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

                tbx_1_number = 0;
                tbx_2_number = 0;
                tbx_3_number = 0;
                tbx_4_number = 0;
                tbx_5_number = 0;
                tbx_6_number = 0;
                tbx_7_number = 0;
                tbx_8_number = 0;
                tbx_9_number = 0;
                tbx_10_number = 0;
                tbx_11_number = 0;
                tbx_12_number = 0;
                tbx_13_number = 0;
                tbx_14_number = 0;
                tbx_15_number = 0;
                tbx_16_number = 0;
                tbx_17_number = 0;
                tbx_18_number = 0;
                tbx_19_number = 0;
                tbx_20_number = 0;
                tbx_21_number = 0;
                tbx_22_number = 0;
                tbx_23_number = 0;
                tbx_24_number = 0;
                tbx_25_number = 0;
                tbx_26_number = 0;
                tbx_27_number = 0;
                tbx_28_number = 0;
                tbx_29_number = 0;
                tbx_30_number = 0;
                tbx_31_number = 0;
                tbx_32_number = 0;
                tbx_33_number = 0;
                tbx_34_number = 0;
                tbx_35_number = 0;
                tbx_36_number = 0;
                tbx_37_number = 0;
                tbx_38_number = 0;
                tbx_39_number = 0;
                tbx_40_number = 0;
                tbx_41_number = 0;
                tbx_42_number = 0;
                tbx_43_number = 0;
                tbx_44_number = 0;
                tbx_45_number = 0;
                tbx_46_number = 0;
                tbx_47_number = 0;
                tbx_48_number = 0;
                tbx_49_number = 0;
                tbx_50_number = 0;
                tbx_51_number = 0;
                tbx_52_number = 0;
                tbx_53_number = 0;
                tbx_54_number = 0;
                tbx_55_number = 0;
                tbx_56_number = 0;
                tbx_57_number = 0;
                tbx_58_number = 0;
                tbx_59_number = 0;
                tbx_60_number = 0;
                tbx_61_number = 0;
                tbx_62_number = 0;
                tbx_63_number = 0;
                tbx_64_number = 0;
                tbx_65_number = 0;
                tbx_66_number = 0;
                tbx_67_number = 0;
                tbx_68_number = 0;
                tbx_69_number = 0;
                tbx_70_number = 0;
                tbx_71_number = 0;
                tbx_72_number = 0;
                tbx_73_number = 0;
                tbx_74_number = 0;
                tbx_75_number = 0;
                tbx_76_number = 0;
                tbx_77_number = 0;
                tbx_78_number = 0;
                tbx_79_number = 0;
                tbx_80_number = 0;
                tbx_81_number = 0;
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
                pbx_loading.Visible = false;
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
                this.ActiveControl = lbl_version;
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
                this.ActiveControl = lbl_version;
                if (numOfInputs >= 10)
                {
                    pbx_loading.Visible = true;
                    disable_tbx();
                    get_tbx_variables();
                    set_tbx_color();
                    sudokuSolver solver = new sudokuSolver(serializeGrid());
                    solver.solve();
                    pbx_loading.Visible = false;
                }
                else
                {
                    MessageBox.Show("You haven't entered the minimum of 10 numbers." + Environment.NewLine + "You entered: " + numOfInputs + " numbers!", "Insufficient numbers!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void disable_tbx()
        {
            try
            {
                tbx_1.ReadOnly = true;
                tbx_2.ReadOnly = true;
                tbx_3.ReadOnly = true;
                tbx_4.ReadOnly = true;
                tbx_5.ReadOnly = true;
                tbx_6.ReadOnly = true;
                tbx_7.ReadOnly = true;
                tbx_8.ReadOnly = true;
                tbx_9.ReadOnly = true;
                tbx_10.ReadOnly = true;
                tbx_11.ReadOnly = true;
                tbx_12.ReadOnly = true;
                tbx_13.ReadOnly = true;
                tbx_14.ReadOnly = true;
                tbx_15.ReadOnly = true;
                tbx_16.ReadOnly = true;
                tbx_17.ReadOnly = true;
                tbx_18.ReadOnly = true;
                tbx_19.ReadOnly = true;
                tbx_20.ReadOnly = true;
                tbx_21.ReadOnly = true;
                tbx_22.ReadOnly = true;
                tbx_23.ReadOnly = true;
                tbx_24.ReadOnly = true;
                tbx_25.ReadOnly = true;
                tbx_26.ReadOnly = true;
                tbx_27.ReadOnly = true;
                tbx_28.ReadOnly = true;
                tbx_29.ReadOnly = true;
                tbx_30.ReadOnly = true;
                tbx_31.ReadOnly = true;
                tbx_32.ReadOnly = true;
                tbx_33.ReadOnly = true;
                tbx_34.ReadOnly = true;
                tbx_35.ReadOnly = true;
                tbx_36.ReadOnly = true;
                tbx_37.ReadOnly = true;
                tbx_38.ReadOnly = true;
                tbx_39.ReadOnly = true;
                tbx_40.ReadOnly = true;
                tbx_41.ReadOnly = true;
                tbx_42.ReadOnly = true;
                tbx_43.ReadOnly = true;
                tbx_44.ReadOnly = true;
                tbx_45.ReadOnly = true;
                tbx_46.ReadOnly = true;
                tbx_47.ReadOnly = true;
                tbx_48.ReadOnly = true;
                tbx_49.ReadOnly = true;
                tbx_50.ReadOnly = true;
                tbx_51.ReadOnly = true;
                tbx_52.ReadOnly = true;
                tbx_53.ReadOnly = true;
                tbx_54.ReadOnly = true;
                tbx_55.ReadOnly = true;
                tbx_56.ReadOnly = true;
                tbx_57.ReadOnly = true;
                tbx_58.ReadOnly = true;
                tbx_59.ReadOnly = true;
                tbx_60.ReadOnly = true;
                tbx_61.ReadOnly = true;
                tbx_62.ReadOnly = true;
                tbx_63.ReadOnly = true;
                tbx_64.ReadOnly = true;
                tbx_65.ReadOnly = true;
                tbx_66.ReadOnly = true;
                tbx_67.ReadOnly = true;
                tbx_68.ReadOnly = true;
                tbx_69.ReadOnly = true;
                tbx_70.ReadOnly = true;
                tbx_71.ReadOnly = true;
                tbx_72.ReadOnly = true;
                tbx_73.ReadOnly = true;
                tbx_74.ReadOnly = true;
                tbx_75.ReadOnly = true;
                tbx_76.ReadOnly = true;
                tbx_77.ReadOnly = true;
                tbx_78.ReadOnly = true;
                tbx_79.ReadOnly = true;
                tbx_80.ReadOnly = true;
                tbx_81.ReadOnly = true;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void get_tbx_variables()
        {
            try
            {
                tbx_1_number = (tbx_1.Text != "" ? int.Parse(tbx_1.Text) : 0);
                tbx_2_number = (tbx_2.Text != "" ? int.Parse(tbx_2.Text) : 0);
                tbx_3_number = (tbx_3.Text != "" ? int.Parse(tbx_3.Text) : 0);
                tbx_4_number = (tbx_4.Text != "" ? int.Parse(tbx_4.Text) : 0);
                tbx_5_number = (tbx_5.Text != "" ? int.Parse(tbx_5.Text) : 0);
                tbx_6_number = (tbx_6.Text != "" ? int.Parse(tbx_6.Text) : 0);
                tbx_7_number = (tbx_7.Text != "" ? int.Parse(tbx_7.Text) : 0);
                tbx_8_number = (tbx_8.Text != "" ? int.Parse(tbx_8.Text) : 0);
                tbx_9_number = (tbx_9.Text != "" ? int.Parse(tbx_9.Text) : 0);
                tbx_10_number = (tbx_10.Text != "" ? int.Parse(tbx_10.Text) : 0);
                tbx_11_number = (tbx_11.Text != "" ? int.Parse(tbx_11.Text) : 0);
                tbx_12_number = (tbx_12.Text != "" ? int.Parse(tbx_12.Text) : 0);
                tbx_13_number = (tbx_13.Text != "" ? int.Parse(tbx_13.Text) : 0);
                tbx_14_number = (tbx_14.Text != "" ? int.Parse(tbx_14.Text) : 0);
                tbx_15_number = (tbx_15.Text != "" ? int.Parse(tbx_15.Text) : 0);
                tbx_16_number = (tbx_16.Text != "" ? int.Parse(tbx_16.Text) : 0);
                tbx_17_number = (tbx_17.Text != "" ? int.Parse(tbx_17.Text) : 0);
                tbx_18_number = (tbx_18.Text != "" ? int.Parse(tbx_18.Text) : 0);
                tbx_19_number = (tbx_19.Text != "" ? int.Parse(tbx_19.Text) : 0);
                tbx_20_number = (tbx_20.Text != "" ? int.Parse(tbx_20.Text) : 0);
                tbx_21_number = (tbx_21.Text != "" ? int.Parse(tbx_21.Text) : 0);
                tbx_22_number = (tbx_22.Text != "" ? int.Parse(tbx_22.Text) : 0);
                tbx_23_number = (tbx_23.Text != "" ? int.Parse(tbx_23.Text) : 0);
                tbx_24_number = (tbx_24.Text != "" ? int.Parse(tbx_24.Text) : 0);
                tbx_25_number = (tbx_25.Text != "" ? int.Parse(tbx_25.Text) : 0);
                tbx_26_number = (tbx_26.Text != "" ? int.Parse(tbx_26.Text) : 0);
                tbx_27_number = (tbx_27.Text != "" ? int.Parse(tbx_27.Text) : 0);
                tbx_28_number = (tbx_28.Text != "" ? int.Parse(tbx_28.Text) : 0);
                tbx_29_number = (tbx_29.Text != "" ? int.Parse(tbx_29.Text) : 0);
                tbx_30_number = (tbx_30.Text != "" ? int.Parse(tbx_30.Text) : 0);
                tbx_31_number = (tbx_31.Text != "" ? int.Parse(tbx_31.Text) : 0);
                tbx_32_number = (tbx_32.Text != "" ? int.Parse(tbx_32.Text) : 0);
                tbx_33_number = (tbx_33.Text != "" ? int.Parse(tbx_33.Text) : 0);
                tbx_34_number = (tbx_34.Text != "" ? int.Parse(tbx_34.Text) : 0);
                tbx_35_number = (tbx_35.Text != "" ? int.Parse(tbx_35.Text) : 0);
                tbx_36_number = (tbx_36.Text != "" ? int.Parse(tbx_36.Text) : 0);
                tbx_37_number = (tbx_37.Text != "" ? int.Parse(tbx_37.Text) : 0);
                tbx_38_number = (tbx_38.Text != "" ? int.Parse(tbx_38.Text) : 0);
                tbx_39_number = (tbx_39.Text != "" ? int.Parse(tbx_39.Text) : 0);
                tbx_40_number = (tbx_40.Text != "" ? int.Parse(tbx_40.Text) : 0);
                tbx_41_number = (tbx_41.Text != "" ? int.Parse(tbx_41.Text) : 0);
                tbx_42_number = (tbx_42.Text != "" ? int.Parse(tbx_42.Text) : 0);
                tbx_43_number = (tbx_43.Text != "" ? int.Parse(tbx_43.Text) : 0);
                tbx_44_number = (tbx_44.Text != "" ? int.Parse(tbx_44.Text) : 0);
                tbx_45_number = (tbx_45.Text != "" ? int.Parse(tbx_45.Text) : 0);
                tbx_46_number = (tbx_46.Text != "" ? int.Parse(tbx_46.Text) : 0);
                tbx_47_number = (tbx_47.Text != "" ? int.Parse(tbx_47.Text) : 0);
                tbx_48_number = (tbx_48.Text != "" ? int.Parse(tbx_48.Text) : 0);
                tbx_49_number = (tbx_49.Text != "" ? int.Parse(tbx_49.Text) : 0);
                tbx_50_number = (tbx_50.Text != "" ? int.Parse(tbx_50.Text) : 0);
                tbx_51_number = (tbx_51.Text != "" ? int.Parse(tbx_51.Text) : 0);
                tbx_52_number = (tbx_52.Text != "" ? int.Parse(tbx_52.Text) : 0);
                tbx_53_number = (tbx_53.Text != "" ? int.Parse(tbx_53.Text) : 0);
                tbx_54_number = (tbx_54.Text != "" ? int.Parse(tbx_54.Text) : 0);
                tbx_55_number = (tbx_55.Text != "" ? int.Parse(tbx_55.Text) : 0);
                tbx_56_number = (tbx_56.Text != "" ? int.Parse(tbx_56.Text) : 0);
                tbx_57_number = (tbx_57.Text != "" ? int.Parse(tbx_57.Text) : 0);
                tbx_58_number = (tbx_58.Text != "" ? int.Parse(tbx_58.Text) : 0);
                tbx_59_number = (tbx_59.Text != "" ? int.Parse(tbx_59.Text) : 0);
                tbx_60_number = (tbx_60.Text != "" ? int.Parse(tbx_60.Text) : 0);
                tbx_61_number = (tbx_61.Text != "" ? int.Parse(tbx_61.Text) : 0);
                tbx_62_number = (tbx_62.Text != "" ? int.Parse(tbx_62.Text) : 0);
                tbx_63_number = (tbx_63.Text != "" ? int.Parse(tbx_63.Text) : 0);
                tbx_64_number = (tbx_64.Text != "" ? int.Parse(tbx_64.Text) : 0);
                tbx_65_number = (tbx_65.Text != "" ? int.Parse(tbx_65.Text) : 0);
                tbx_66_number = (tbx_66.Text != "" ? int.Parse(tbx_66.Text) : 0);
                tbx_67_number = (tbx_67.Text != "" ? int.Parse(tbx_67.Text) : 0);
                tbx_68_number = (tbx_68.Text != "" ? int.Parse(tbx_68.Text) : 0);
                tbx_69_number = (tbx_69.Text != "" ? int.Parse(tbx_69.Text) : 0);
                tbx_70_number = (tbx_70.Text != "" ? int.Parse(tbx_70.Text) : 0);
                tbx_71_number = (tbx_71.Text != "" ? int.Parse(tbx_71.Text) : 0);
                tbx_72_number = (tbx_72.Text != "" ? int.Parse(tbx_72.Text) : 0);
                tbx_73_number = (tbx_73.Text != "" ? int.Parse(tbx_73.Text) : 0);
                tbx_74_number = (tbx_74.Text != "" ? int.Parse(tbx_74.Text) : 0);
                tbx_75_number = (tbx_75.Text != "" ? int.Parse(tbx_75.Text) : 0);
                tbx_76_number = (tbx_76.Text != "" ? int.Parse(tbx_76.Text) : 0);
                tbx_77_number = (tbx_77.Text != "" ? int.Parse(tbx_77.Text) : 0);
                tbx_78_number = (tbx_78.Text != "" ? int.Parse(tbx_78.Text) : 0);
                tbx_79_number = (tbx_79.Text != "" ? int.Parse(tbx_79.Text) : 0);
                tbx_80_number = (tbx_80.Text != "" ? int.Parse(tbx_80.Text) : 0);
                tbx_81_number = (tbx_81.Text != "" ? int.Parse(tbx_81.Text) : 0);
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void set_tbx_color()
        {
            try
            {
                if (tbx_1_number != 0)
                    tbx_1.ForeColor = Color.Red;
                else
                    tbx_1.ForeColor = Color.Blue;

                if (tbx_2_number != 0)
                    tbx_2.ForeColor = Color.Red;
                else
                    tbx_2.ForeColor = Color.Blue;

                if (tbx_3_number != 0)
                    tbx_3.ForeColor = Color.Red;
                else
                    tbx_3.ForeColor = Color.Blue;

                if (tbx_4_number != 0)
                    tbx_4.ForeColor = Color.Red;
                else
                    tbx_4.ForeColor = Color.Blue;

                if (tbx_5_number != 0)
                    tbx_5.ForeColor = Color.Red;
                else
                    tbx_5.ForeColor = Color.Blue;

                if (tbx_6_number != 0)
                    tbx_6.ForeColor = Color.Red;
                else
                    tbx_6.ForeColor = Color.Blue;

                if (tbx_7_number != 0)
                    tbx_7.ForeColor = Color.Red;
                else
                    tbx_7.ForeColor = Color.Blue;

                if (tbx_8_number != 0)
                    tbx_8.ForeColor = Color.Red;
                else
                    tbx_8.ForeColor = Color.Blue;

                if (tbx_9_number != 0)
                    tbx_9.ForeColor = Color.Red;
                else
                    tbx_9.ForeColor = Color.Blue;

                if (tbx_10_number != 0)
                    tbx_10.ForeColor = Color.Red;
                else
                    tbx_10.ForeColor = Color.Blue;

                if (tbx_11_number != 0)
                    tbx_11.ForeColor = Color.Red;
                else
                    tbx_11.ForeColor = Color.Blue;

                if (tbx_12_number != 0)
                    tbx_12.ForeColor = Color.Red;
                else
                    tbx_12.ForeColor = Color.Blue;

                if (tbx_13_number != 0)
                    tbx_13.ForeColor = Color.Red;
                else
                    tbx_13.ForeColor = Color.Blue;

                if (tbx_14_number != 0)
                    tbx_14.ForeColor = Color.Red;
                else
                    tbx_14.ForeColor = Color.Blue;

                if (tbx_15_number != 0)
                    tbx_15.ForeColor = Color.Red;
                else
                    tbx_15.ForeColor = Color.Blue;

                if (tbx_16_number != 0)
                    tbx_16.ForeColor = Color.Red;
                else
                    tbx_16.ForeColor = Color.Blue;

                if (tbx_17_number != 0)
                    tbx_17.ForeColor = Color.Red;
                else
                    tbx_17.ForeColor = Color.Blue;

                if (tbx_18_number != 0)
                    tbx_18.ForeColor = Color.Red;
                else
                    tbx_18.ForeColor = Color.Blue;

                if (tbx_19_number != 0)
                    tbx_19.ForeColor = Color.Red;
                else
                    tbx_19.ForeColor = Color.Blue;

                if (tbx_20_number != 0)
                    tbx_20.ForeColor = Color.Red;
                else
                    tbx_20.ForeColor = Color.Blue;

                if (tbx_21_number != 0)
                    tbx_21.ForeColor = Color.Red;
                else
                    tbx_21.ForeColor = Color.Blue;

                if (tbx_22_number != 0)
                    tbx_22.ForeColor = Color.Red;
                else
                    tbx_22.ForeColor = Color.Blue;

                if (tbx_23_number != 0)
                    tbx_23.ForeColor = Color.Red;
                else
                    tbx_23.ForeColor = Color.Blue;

                if (tbx_24_number != 0)
                    tbx_24.ForeColor = Color.Red;
                else
                    tbx_24.ForeColor = Color.Blue;

                if (tbx_25_number != 0)
                    tbx_25.ForeColor = Color.Red;
                else
                    tbx_25.ForeColor = Color.Blue;

                if (tbx_26_number != 0)
                    tbx_26.ForeColor = Color.Red;
                else
                    tbx_26.ForeColor = Color.Blue;

                if (tbx_27_number != 0)
                    tbx_27.ForeColor = Color.Red;
                else
                    tbx_27.ForeColor = Color.Blue;

                if (tbx_28_number != 0)
                    tbx_28.ForeColor = Color.Red;
                else
                    tbx_28.ForeColor = Color.Blue;

                if (tbx_29_number != 0)
                    tbx_29.ForeColor = Color.Red;
                else
                    tbx_29.ForeColor = Color.Blue;

                if (tbx_30_number != 0)
                    tbx_30.ForeColor = Color.Red;
                else
                    tbx_30.ForeColor = Color.Blue;

                if (tbx_31_number != 0)
                    tbx_31.ForeColor = Color.Red;
                else
                    tbx_31.ForeColor = Color.Blue;

                if (tbx_32_number != 0)
                    tbx_32.ForeColor = Color.Red;
                else
                    tbx_32.ForeColor = Color.Blue;

                if (tbx_33_number != 0)
                    tbx_33.ForeColor = Color.Red;
                else
                    tbx_33.ForeColor = Color.Blue;

                if (tbx_34_number != 0)
                    tbx_34.ForeColor = Color.Red;
                else
                    tbx_34.ForeColor = Color.Blue;

                if (tbx_35_number != 0)
                    tbx_35.ForeColor = Color.Red;
                else
                    tbx_35.ForeColor = Color.Blue;

                if (tbx_36_number != 0)
                    tbx_36.ForeColor = Color.Red;
                else
                    tbx_36.ForeColor = Color.Blue;

                if (tbx_37_number != 0)
                    tbx_37.ForeColor = Color.Red;
                else
                    tbx_37.ForeColor = Color.Blue;

                if (tbx_38_number != 0)
                    tbx_38.ForeColor = Color.Red;
                else
                    tbx_38.ForeColor = Color.Blue;

                if (tbx_39_number != 0)
                    tbx_39.ForeColor = Color.Red;
                else
                    tbx_39.ForeColor = Color.Blue;

                if (tbx_40_number != 0)
                    tbx_40.ForeColor = Color.Red;
                else
                    tbx_40.ForeColor = Color.Blue;

                if (tbx_41_number != 0)
                    tbx_41.ForeColor = Color.Red;
                else
                    tbx_41.ForeColor = Color.Blue;

                if (tbx_42_number != 0)
                    tbx_42.ForeColor = Color.Red;
                else
                    tbx_42.ForeColor = Color.Blue;

                if (tbx_43_number != 0)
                    tbx_43.ForeColor = Color.Red;
                else
                    tbx_43.ForeColor = Color.Blue;

                if (tbx_44_number != 0)
                    tbx_44.ForeColor = Color.Red;
                else
                    tbx_44.ForeColor = Color.Blue;

                if (tbx_45_number != 0)
                    tbx_45.ForeColor = Color.Red;
                else
                    tbx_45.ForeColor = Color.Blue;

                if (tbx_46_number != 0)
                    tbx_46.ForeColor = Color.Red;
                else
                    tbx_46.ForeColor = Color.Blue;

                if (tbx_47_number != 0)
                    tbx_47.ForeColor = Color.Red;
                else
                    tbx_47.ForeColor = Color.Blue;

                if (tbx_48_number != 0)
                    tbx_48.ForeColor = Color.Red;
                else
                    tbx_48.ForeColor = Color.Blue;

                if (tbx_49_number != 0)
                    tbx_49.ForeColor = Color.Red;
                else
                    tbx_49.ForeColor = Color.Blue;

                if (tbx_50_number != 0)
                    tbx_50.ForeColor = Color.Red;
                else
                    tbx_50.ForeColor = Color.Blue;

                if (tbx_51_number != 0)
                    tbx_51.ForeColor = Color.Red;
                else
                    tbx_51.ForeColor = Color.Blue;

                if (tbx_52_number != 0)
                    tbx_52.ForeColor = Color.Red;
                else
                    tbx_52.ForeColor = Color.Blue;

                if (tbx_53_number != 0)
                    tbx_53.ForeColor = Color.Red;
                else
                    tbx_53.ForeColor = Color.Blue;

                if (tbx_54_number != 0)
                    tbx_54.ForeColor = Color.Red;
                else
                    tbx_54.ForeColor = Color.Blue;

                if (tbx_55_number != 0)
                    tbx_55.ForeColor = Color.Red;
                else
                    tbx_55.ForeColor = Color.Blue;

                if (tbx_56_number != 0)
                    tbx_56.ForeColor = Color.Red;
                else
                    tbx_56.ForeColor = Color.Blue;

                if (tbx_57_number != 0)
                    tbx_57.ForeColor = Color.Red;
                else
                    tbx_57.ForeColor = Color.Blue;

                if (tbx_58_number != 0)
                    tbx_58.ForeColor = Color.Red;
                else
                    tbx_58.ForeColor = Color.Blue;

                if (tbx_59_number != 0)
                    tbx_59.ForeColor = Color.Red;
                else
                    tbx_59.ForeColor = Color.Blue;

                if (tbx_60_number != 0)
                    tbx_60.ForeColor = Color.Red;
                else
                    tbx_60.ForeColor = Color.Blue;

                if (tbx_61_number != 0)
                    tbx_61.ForeColor = Color.Red;
                else
                    tbx_61.ForeColor = Color.Blue;

                if (tbx_62_number != 0)
                    tbx_62.ForeColor = Color.Red;
                else
                    tbx_62.ForeColor = Color.Blue;

                if (tbx_63_number != 0)
                    tbx_63.ForeColor = Color.Red;
                else
                    tbx_63.ForeColor = Color.Blue;

                if (tbx_64_number != 0)
                    tbx_64.ForeColor = Color.Red;
                else
                    tbx_64.ForeColor = Color.Blue;

                if (tbx_65_number != 0)
                    tbx_65.ForeColor = Color.Red;
                else
                    tbx_65.ForeColor = Color.Blue;

                if (tbx_66_number != 0)
                    tbx_66.ForeColor = Color.Red;
                else
                    tbx_66.ForeColor = Color.Blue;

                if (tbx_67_number != 0)
                    tbx_67.ForeColor = Color.Red;
                else
                    tbx_67.ForeColor = Color.Blue;

                if (tbx_68_number != 0)
                    tbx_68.ForeColor = Color.Red;
                else
                    tbx_68.ForeColor = Color.Blue;

                if (tbx_69_number != 0)
                    tbx_69.ForeColor = Color.Red;
                else
                    tbx_69.ForeColor = Color.Blue;

                if (tbx_70_number != 0)
                    tbx_70.ForeColor = Color.Red;
                else
                    tbx_70.ForeColor = Color.Blue;

                if (tbx_71_number != 0)
                    tbx_71.ForeColor = Color.Red;
                else
                    tbx_71.ForeColor = Color.Blue;

                if (tbx_72_number != 0)
                    tbx_72.ForeColor = Color.Red;
                else
                    tbx_72.ForeColor = Color.Blue;

                if (tbx_73_number != 0)
                    tbx_73.ForeColor = Color.Red;
                else
                    tbx_73.ForeColor = Color.Blue;

                if (tbx_74_number != 0)
                    tbx_74.ForeColor = Color.Red;
                else
                    tbx_74.ForeColor = Color.Blue;

                if (tbx_75_number != 0)
                    tbx_75.ForeColor = Color.Red;
                else
                    tbx_75.ForeColor = Color.Blue;

                if (tbx_76_number != 0)
                    tbx_76.ForeColor = Color.Red;
                else
                    tbx_76.ForeColor = Color.Blue;

                if (tbx_77_number != 0)
                    tbx_77.ForeColor = Color.Red;
                else
                    tbx_77.ForeColor = Color.Blue;

                if (tbx_78_number != 0)
                    tbx_78.ForeColor = Color.Red;
                else
                    tbx_78.ForeColor = Color.Blue;

                if (tbx_79_number != 0)
                    tbx_79.ForeColor = Color.Red;
                else
                    tbx_79.ForeColor = Color.Blue;

                if (tbx_80_number != 0)
                    tbx_80.ForeColor = Color.Red;
                else
                    tbx_80.ForeColor = Color.Blue;

                if (tbx_81_number != 0)
                    tbx_81.ForeColor = Color.Red;
                else
                    tbx_81.ForeColor = Color.Blue;

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
                pbx_loading.Visible = true;
                resetCtor();
                resetLoad();
                btn_solve.Enabled = true;
                lbl_numOfResults.Text = "";
                lbl_currentPage.Text = "";

                tbx_1.ReadOnly = false;
                tbx_2.ReadOnly = false;
                tbx_3.ReadOnly = false;
                tbx_4.ReadOnly = false;
                tbx_5.ReadOnly = false;
                tbx_6.ReadOnly = false;
                tbx_7.ReadOnly = false;
                tbx_8.ReadOnly = false;
                tbx_9.ReadOnly = false;
                tbx_10.ReadOnly = false;
                tbx_11.ReadOnly = false;
                tbx_12.ReadOnly = false;
                tbx_13.ReadOnly = false;
                tbx_14.ReadOnly = false;
                tbx_15.ReadOnly = false;
                tbx_16.ReadOnly = false;
                tbx_17.ReadOnly = false;
                tbx_18.ReadOnly = false;
                tbx_19.ReadOnly = false;
                tbx_20.ReadOnly = false;
                tbx_21.ReadOnly = false;
                tbx_22.ReadOnly = false;
                tbx_23.ReadOnly = false;
                tbx_24.ReadOnly = false;
                tbx_25.ReadOnly = false;
                tbx_26.ReadOnly = false;
                tbx_27.ReadOnly = false;
                tbx_28.ReadOnly = false;
                tbx_29.ReadOnly = false;
                tbx_30.ReadOnly = false;
                tbx_31.ReadOnly = false;
                tbx_32.ReadOnly = false;
                tbx_33.ReadOnly = false;
                tbx_34.ReadOnly = false;
                tbx_35.ReadOnly = false;
                tbx_36.ReadOnly = false;
                tbx_37.ReadOnly = false;
                tbx_38.ReadOnly = false;
                tbx_39.ReadOnly = false;
                tbx_40.ReadOnly = false;
                tbx_41.ReadOnly = false;
                tbx_42.ReadOnly = false;
                tbx_43.ReadOnly = false;
                tbx_44.ReadOnly = false;
                tbx_45.ReadOnly = false;
                tbx_46.ReadOnly = false;
                tbx_47.ReadOnly = false;
                tbx_48.ReadOnly = false;
                tbx_49.ReadOnly = false;
                tbx_50.ReadOnly = false;
                tbx_51.ReadOnly = false;
                tbx_52.ReadOnly = false;
                tbx_53.ReadOnly = false;
                tbx_54.ReadOnly = false;
                tbx_55.ReadOnly = false;
                tbx_56.ReadOnly = false;
                tbx_57.ReadOnly = false;
                tbx_58.ReadOnly = false;
                tbx_59.ReadOnly = false;
                tbx_60.ReadOnly = false;
                tbx_61.ReadOnly = false;
                tbx_62.ReadOnly = false;
                tbx_63.ReadOnly = false;
                tbx_64.ReadOnly = false;
                tbx_65.ReadOnly = false;
                tbx_66.ReadOnly = false;
                tbx_67.ReadOnly = false;
                tbx_68.ReadOnly = false;
                tbx_69.ReadOnly = false;
                tbx_70.ReadOnly = false;
                tbx_71.ReadOnly = false;
                tbx_72.ReadOnly = false;
                tbx_73.ReadOnly = false;
                tbx_74.ReadOnly = false;
                tbx_75.ReadOnly = false;
                tbx_76.ReadOnly = false;
                tbx_77.ReadOnly = false;
                tbx_78.ReadOnly = false;
                tbx_79.ReadOnly = false;
                tbx_80.ReadOnly = false;
                tbx_81.ReadOnly = false;

                tbx_1.Text = "";
                tbx_2.Text = "";
                tbx_3.Text = "";
                tbx_4.Text = "";
                tbx_5.Text = "";
                tbx_6.Text = "";
                tbx_7.Text = "";
                tbx_8.Text = "";
                tbx_9.Text = "";
                tbx_10.Text = "";
                tbx_11.Text = "";
                tbx_12.Text = "";
                tbx_13.Text = "";
                tbx_14.Text = "";
                tbx_15.Text = "";
                tbx_16.Text = "";
                tbx_17.Text = "";
                tbx_18.Text = "";
                tbx_19.Text = "";
                tbx_20.Text = "";
                tbx_21.Text = "";
                tbx_22.Text = "";
                tbx_23.Text = "";
                tbx_24.Text = "";
                tbx_25.Text = "";
                tbx_26.Text = "";
                tbx_27.Text = "";
                tbx_28.Text = "";
                tbx_29.Text = "";
                tbx_30.Text = "";
                tbx_31.Text = "";
                tbx_32.Text = "";
                tbx_33.Text = "";
                tbx_34.Text = "";
                tbx_35.Text = "";
                tbx_36.Text = "";
                tbx_37.Text = "";
                tbx_38.Text = "";
                tbx_39.Text = "";
                tbx_40.Text = "";
                tbx_41.Text = "";
                tbx_42.Text = "";
                tbx_43.Text = "";
                tbx_44.Text = "";
                tbx_45.Text = "";
                tbx_46.Text = "";
                tbx_47.Text = "";
                tbx_48.Text = "";
                tbx_49.Text = "";
                tbx_50.Text = "";
                tbx_51.Text = "";
                tbx_52.Text = "";
                tbx_53.Text = "";
                tbx_54.Text = "";
                tbx_55.Text = "";
                tbx_56.Text = "";
                tbx_57.Text = "";
                tbx_58.Text = "";
                tbx_59.Text = "";
                tbx_60.Text = "";
                tbx_61.Text = "";
                tbx_62.Text = "";
                tbx_63.Text = "";
                tbx_64.Text = "";
                tbx_65.Text = "";
                tbx_66.Text = "";
                tbx_67.Text = "";
                tbx_68.Text = "";
                tbx_69.Text = "";
                tbx_70.Text = "";
                tbx_71.Text = "";
                tbx_72.Text = "";
                tbx_73.Text = "";
                tbx_74.Text = "";
                tbx_75.Text = "";
                tbx_76.Text = "";
                tbx_77.Text = "";
                tbx_78.Text = "";
                tbx_79.Text = "";
                tbx_80.Text = "";
                tbx_81.Text = "";

                tbx_1.ForeColor = Color.Black;
                tbx_2.ForeColor = Color.Black;
                tbx_3.ForeColor = Color.Black;
                tbx_4.ForeColor = Color.Black;
                tbx_5.ForeColor = Color.Black;
                tbx_6.ForeColor = Color.Black;
                tbx_7.ForeColor = Color.Black;
                tbx_8.ForeColor = Color.Black;
                tbx_9.ForeColor = Color.Black;
                tbx_10.ForeColor = Color.Black;
                tbx_11.ForeColor = Color.Black;
                tbx_12.ForeColor = Color.Black;
                tbx_13.ForeColor = Color.Black;
                tbx_14.ForeColor = Color.Black;
                tbx_15.ForeColor = Color.Black;
                tbx_16.ForeColor = Color.Black;
                tbx_17.ForeColor = Color.Black;
                tbx_18.ForeColor = Color.Black;
                tbx_19.ForeColor = Color.Black;
                tbx_20.ForeColor = Color.Black;
                tbx_21.ForeColor = Color.Black;
                tbx_22.ForeColor = Color.Black;
                tbx_23.ForeColor = Color.Black;
                tbx_24.ForeColor = Color.Black;
                tbx_25.ForeColor = Color.Black;
                tbx_26.ForeColor = Color.Black;
                tbx_27.ForeColor = Color.Black;
                tbx_28.ForeColor = Color.Black;
                tbx_29.ForeColor = Color.Black;
                tbx_30.ForeColor = Color.Black;
                tbx_31.ForeColor = Color.Black;
                tbx_32.ForeColor = Color.Black;
                tbx_33.ForeColor = Color.Black;
                tbx_34.ForeColor = Color.Black;
                tbx_35.ForeColor = Color.Black;
                tbx_36.ForeColor = Color.Black;
                tbx_37.ForeColor = Color.Black;
                tbx_38.ForeColor = Color.Black;
                tbx_39.ForeColor = Color.Black;
                tbx_40.ForeColor = Color.Black;
                tbx_41.ForeColor = Color.Black;
                tbx_42.ForeColor = Color.Black;
                tbx_43.ForeColor = Color.Black;
                tbx_44.ForeColor = Color.Black;
                tbx_45.ForeColor = Color.Black;
                tbx_46.ForeColor = Color.Black;
                tbx_47.ForeColor = Color.Black;
                tbx_48.ForeColor = Color.Black;
                tbx_49.ForeColor = Color.Black;
                tbx_50.ForeColor = Color.Black;
                tbx_51.ForeColor = Color.Black;
                tbx_52.ForeColor = Color.Black;
                tbx_53.ForeColor = Color.Black;
                tbx_54.ForeColor = Color.Black;
                tbx_55.ForeColor = Color.Black;
                tbx_56.ForeColor = Color.Black;
                tbx_57.ForeColor = Color.Black;
                tbx_58.ForeColor = Color.Black;
                tbx_59.ForeColor = Color.Black;
                tbx_60.ForeColor = Color.Black;
                tbx_61.ForeColor = Color.Black;
                tbx_62.ForeColor = Color.Black;
                tbx_63.ForeColor = Color.Black;
                tbx_64.ForeColor = Color.Black;
                tbx_65.ForeColor = Color.Black;
                tbx_66.ForeColor = Color.Black;
                tbx_67.ForeColor = Color.Black;
                tbx_68.ForeColor = Color.Black;
                tbx_69.ForeColor = Color.Black;
                tbx_70.ForeColor = Color.Black;
                tbx_71.ForeColor = Color.Black;
                tbx_72.ForeColor = Color.Black;
                tbx_73.ForeColor = Color.Black;
                tbx_74.ForeColor = Color.Black;
                tbx_75.ForeColor = Color.Black;
                tbx_76.ForeColor = Color.Black;
                tbx_77.ForeColor = Color.Black;
                tbx_78.ForeColor = Color.Black;
                tbx_79.ForeColor = Color.Black;
                tbx_80.ForeColor = Color.Black;
                tbx_81.ForeColor = Color.Black;

                pbx_loading.Visible = false;
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
            try
            {
                if (tbx_45.Text != "" && tbx_45.Text != "0")
                {
                    tbx_45_used = true;
                    numOfInputs++;
                }
                else if (tbx_45.Text == "" || tbx_45.Text == "0" && tbx_45_used == true)
                {
                    tbx_45_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_46_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_46.Text != "" && tbx_46.Text != "0")
                {
                    tbx_46_used = true;
                    numOfInputs++;
                }
                else if (tbx_46.Text == "" || tbx_46.Text == "0" && tbx_46_used == true)
                {
                    tbx_46_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_47_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_47.Text != "" && tbx_47.Text != "0")
                {
                    tbx_47_used = true;
                    numOfInputs++;
                }
                else if (tbx_47.Text == "" || tbx_47.Text == "0" && tbx_47_used == true)
                {
                    tbx_47_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_48_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_48.Text != "" && tbx_48.Text != "0")
                {
                    tbx_48_used = true;
                    numOfInputs++;
                }
                else if (tbx_48.Text == "" || tbx_48.Text == "0" && tbx_48_used == true)
                {
                    tbx_48_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_49_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_49.Text != "" && tbx_49.Text != "0")
                {
                    tbx_49_used = true;
                    numOfInputs++;
                }
                else if (tbx_49.Text == "" || tbx_49.Text == "0" && tbx_49_used == true)
                {
                    tbx_49_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_50_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_50.Text != "" && tbx_50.Text != "0")
                {
                    tbx_50_used = true;
                    numOfInputs++;
                }
                else if (tbx_50.Text == "" || tbx_50.Text == "0" && tbx_50_used == true)
                {
                    tbx_50_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_51_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_51.Text != "" && tbx_51.Text != "0")
                {
                    tbx_51_used = true;
                    numOfInputs++;
                }
                else if (tbx_51.Text == "" || tbx_51.Text == "0" && tbx_51_used == true)
                {
                    tbx_51_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_52_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_52.Text != "" && tbx_52.Text != "0")
                {
                    tbx_52_used = true;
                    numOfInputs++;
                }
                else if (tbx_52.Text == "" || tbx_52.Text == "0" && tbx_52_used == true)
                {
                    tbx_52_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_53_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_53.Text != "" && tbx_53.Text != "0")
                {
                    tbx_53_used = true;
                    numOfInputs++;
                }
                else if (tbx_53.Text == "" || tbx_53.Text == "0" && tbx_53_used == true)
                {
                    tbx_53_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_54_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_54.Text != "" && tbx_54.Text != "0")
                {
                    tbx_54_used = true;
                    numOfInputs++;
                }
                else if (tbx_54.Text == "" || tbx_54.Text == "0" && tbx_54_used == true)
                {
                    tbx_54_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_55_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_55.Text != "" && tbx_55.Text != "0")
                {
                    tbx_55_used = true;
                    numOfInputs++;
                }
                else if (tbx_55.Text == "" || tbx_55.Text == "0" && tbx_55_used == true)
                {
                    tbx_55_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_56_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_56.Text != "" && tbx_56.Text != "0")
                {
                    tbx_56_used = true;
                    numOfInputs++;
                }
                else if (tbx_56.Text == "" || tbx_56.Text == "0" && tbx_56_used == true)
                {
                    tbx_56_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_57_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_57.Text != "" && tbx_57.Text != "0")
                {
                    tbx_57_used = true;
                    numOfInputs++;
                }
                else if (tbx_57.Text == "" || tbx_57.Text == "0" && tbx_57_used == true)
                {
                    tbx_57_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_58_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_58.Text != "" && tbx_58.Text != "0")
                {
                    tbx_58_used = true;
                    numOfInputs++;
                }
                else if (tbx_58.Text == "" || tbx_58.Text == "0" && tbx_58_used == true)
                {
                    tbx_58_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_59_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_59.Text != "" && tbx_59.Text != "0")
                {
                    tbx_59_used = true;
                    numOfInputs++;
                }
                else if (tbx_59.Text == "" || tbx_59.Text == "0" && tbx_59_used == true)
                {
                    tbx_59_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_60_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_60.Text != "" && tbx_60.Text != "0")
                {
                    tbx_60_used = true;
                    numOfInputs++;
                }
                else if (tbx_60.Text == "" || tbx_60.Text == "0" && tbx_60_used == true)
                {
                    tbx_60_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_61_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_61.Text != "" && tbx_61.Text != "0")
                {
                    tbx_61_used = true;
                    numOfInputs++;
                }
                else if (tbx_61.Text == "" || tbx_61.Text == "0" && tbx_61_used == true)
                {
                    tbx_61_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_62_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_62.Text != "" && tbx_62.Text != "0")
                {
                    tbx_62_used = true;
                    numOfInputs++;
                }
                else if (tbx_62.Text == "" || tbx_62.Text == "0" && tbx_62_used == true)
                {
                    tbx_62_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_63_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_63.Text != "" && tbx_63.Text != "0")
                {
                    tbx_63_used = true;
                    numOfInputs++;
                }
                else if (tbx_63.Text == "" || tbx_63.Text == "0" && tbx_63_used == true)
                {
                    tbx_63_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_64_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_64.Text != "" && tbx_64.Text != "0")
                {
                    tbx_64_used = true;
                    numOfInputs++;
                }
                else if (tbx_64.Text == "" || tbx_64.Text == "0" && tbx_64_used == true)
                {
                    tbx_64_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_65_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_65.Text != "" && tbx_65.Text != "0")
                {
                    tbx_65_used = true;
                    numOfInputs++;
                }
                else if (tbx_65.Text == "" || tbx_65.Text == "0" && tbx_65_used == true)
                {
                    tbx_65_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_66_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_66.Text != "" && tbx_66.Text != "0")
                {
                    tbx_66_used = true;
                    numOfInputs++;
                }
                else if (tbx_66.Text == "" || tbx_66.Text == "0" && tbx_66_used == true)
                {
                    tbx_66_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_67_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_67.Text != "" && tbx_67.Text != "0")
                {
                    tbx_67_used = true;
                    numOfInputs++;
                }
                else if (tbx_67.Text == "" || tbx_67.Text == "0" && tbx_67_used == true)
                {
                    tbx_67_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_68_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_68.Text != "" && tbx_68.Text != "0")
                {
                    tbx_68_used = true;
                    numOfInputs++;
                }
                else if (tbx_68.Text == "" || tbx_68.Text == "0" && tbx_68_used == true)
                {
                    tbx_68_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_69_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_69.Text != "" && tbx_69.Text != "0")
                {
                    tbx_69_used = true;
                    numOfInputs++;
                }
                else if (tbx_69.Text == "" || tbx_69.Text == "0" && tbx_69_used == true)
                {
                    tbx_69_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_70_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_70.Text != "" && tbx_70.Text != "0")
                {
                    tbx_70_used = true;
                    numOfInputs++;
                }
                else if (tbx_70.Text == "" || tbx_70.Text == "0" && tbx_70_used == true)
                {
                    tbx_70_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_71_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_71.Text != "" && tbx_71.Text != "0")
                {
                    tbx_71_used = true;
                    numOfInputs++;
                }
                else if (tbx_71.Text == "" || tbx_71.Text == "0" && tbx_71_used == true)
                {
                    tbx_71_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_72_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_72.Text != "" && tbx_72.Text != "0")
                {
                    tbx_72_used = true;
                    numOfInputs++;
                }
                else if (tbx_72.Text == "" || tbx_72.Text == "0" && tbx_72_used == true)
                {
                    tbx_72_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_73_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_73.Text != "" && tbx_73.Text != "0")
                {
                    tbx_73_used = true;
                    numOfInputs++;
                }
                else if (tbx_73.Text == "" || tbx_73.Text == "0" && tbx_73_used == true)
                {
                    tbx_73_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_74_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_74.Text != "" && tbx_74.Text != "0")
                {
                    tbx_74_used = true;
                    numOfInputs++;
                }
                else if (tbx_74.Text == "" || tbx_74.Text == "0" && tbx_74_used == true)
                {
                    tbx_74_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_75_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_75.Text != "" && tbx_75.Text != "0")
                {
                    tbx_75_used = true;
                    numOfInputs++;
                }
                else if (tbx_75.Text == "" || tbx_75.Text == "0" && tbx_75_used == true)
                {
                    tbx_75_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_76_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_76.Text != "" && tbx_76.Text != "0")
                {
                    tbx_76_used = true;
                    numOfInputs++;
                }
                else if (tbx_76.Text == "" || tbx_76.Text == "0" && tbx_76_used == true)
                {
                    tbx_76_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_77_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_77.Text != "" && tbx_77.Text != "0")
                {
                    tbx_77_used = true;
                    numOfInputs++;
                }
                else if (tbx_77.Text == "" || tbx_77.Text == "0" && tbx_77_used == true)
                {
                    tbx_77_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_78_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_78.Text != "" && tbx_78.Text != "0")
                {
                    tbx_78_used = true;
                    numOfInputs++;
                }
                else if (tbx_78.Text == "" || tbx_78.Text == "0" && tbx_78_used == true)
                {
                    tbx_78_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_79_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_79.Text != "" && tbx_79.Text != "0")
                {
                    tbx_79_used = true;
                    numOfInputs++;
                }
                else if (tbx_79.Text == "" || tbx_79.Text == "0" && tbx_79_used == true)
                {
                    tbx_79_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_80_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_80.Text != "" && tbx_80.Text != "0")
                {
                    tbx_80_used = true;
                    numOfInputs++;
                }
                else if (tbx_80.Text == "" || tbx_80.Text == "0" && tbx_80_used == true)
                {
                    tbx_80_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        private void tbx_81_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_81.Text != "" && tbx_81.Text != "0")
                {
                    tbx_81_used = true;
                    numOfInputs++;
                }
                else if (tbx_81.Text == "" || tbx_81.Text == "0" && tbx_81_used == true)
                {
                    tbx_81_used = false;
                    numOfInputs--;
                }
            }
            catch (Exception ex)
            {
                errorHandler(ex);
            }
        }

        #endregion

        private int[] serializeGrid()
        {
            try
            {
                int[] grid = new int[81];
                grid[0] = tbx_1_number;
                grid[1] = tbx_2_number;
                grid[2] = tbx_3_number;
                grid[3] = tbx_4_number;
                grid[4] = tbx_5_number;
                grid[5] = tbx_6_number;
                grid[6] = tbx_7_number;
                grid[7] = tbx_8_number;
                grid[8] = tbx_9_number;
                grid[9] = tbx_10_number;
                grid[10] = tbx_11_number;
                grid[11] = tbx_12_number;
                grid[12] = tbx_13_number;
                grid[13] = tbx_14_number;
                grid[14] = tbx_15_number;
                grid[15] = tbx_16_number;
                grid[16] = tbx_17_number;
                grid[17] = tbx_18_number;
                grid[18] = tbx_19_number;
                grid[19] = tbx_20_number;
                grid[20] = tbx_21_number;
                grid[21] = tbx_22_number;
                grid[22] = tbx_23_number;
                grid[23] = tbx_24_number;
                grid[24] = tbx_25_number;
                grid[25] = tbx_26_number;
                grid[26] = tbx_27_number;
                grid[27] = tbx_28_number;
                grid[28] = tbx_29_number;
                grid[29] = tbx_30_number;
                grid[30] = tbx_31_number;
                grid[31] = tbx_32_number;
                grid[32] = tbx_33_number;
                grid[33] = tbx_34_number;
                grid[34] = tbx_35_number;
                grid[35] = tbx_36_number;
                grid[36] = tbx_37_number;
                grid[37] = tbx_38_number;
                grid[38] = tbx_39_number;
                grid[39] = tbx_40_number;
                grid[40] = tbx_41_number;
                grid[41] = tbx_42_number;
                grid[42] = tbx_43_number;
                grid[43] = tbx_44_number;
                grid[44] = tbx_45_number;
                grid[45] = tbx_46_number;
                grid[46] = tbx_47_number;
                grid[47] = tbx_48_number;
                grid[48] = tbx_49_number;
                grid[49] = tbx_50_number;
                grid[50] = tbx_51_number;
                grid[51] = tbx_52_number;
                grid[52] = tbx_53_number;
                grid[53] = tbx_54_number;
                grid[54] = tbx_55_number;
                grid[55] = tbx_56_number;
                grid[56] = tbx_57_number;
                grid[57] = tbx_58_number;
                grid[58] = tbx_59_number;
                grid[59] = tbx_60_number;
                grid[60] = tbx_61_number;
                grid[61] = tbx_62_number;
                grid[62] = tbx_63_number;
                grid[63] = tbx_64_number;
                grid[64] = tbx_65_number;
                grid[65] = tbx_66_number;
                grid[66] = tbx_67_number;
                grid[67] = tbx_68_number;
                grid[68] = tbx_69_number;
                grid[69] = tbx_70_number;
                grid[70] = tbx_71_number;
                grid[71] = tbx_72_number;
                grid[72] = tbx_73_number;
                grid[73] = tbx_74_number;
                grid[74] = tbx_75_number;
                grid[75] = tbx_76_number;
                grid[76] = tbx_77_number;
                grid[77] = tbx_78_number;
                grid[78] = tbx_79_number;
                grid[79] = tbx_80_number;
                grid[80] = tbx_81_number;

                return grid;
            }
            catch (Exception ex)
            {
                errorHandler(ex);
                return null;
            }
        }

    }
}