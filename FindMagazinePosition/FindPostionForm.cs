using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FindMagazinePosition
{
    public partial class FindPostionForm : Form
    {
        private bool[] _places;
        private int _positionsInMagazine; 

        public FindPostionForm()
        {
            InitializeComponent();
        }

        private void FindPostionForm_Load(object sender, EventArgs e)
        {
            rdbLinear.Checked = true;
            beforeMagazigeFormState(); 
        }

        #region Button Action for Magazine creation 
        /// <summary>
        /// Create the Magazine with Free Positions 
        /// Also colored (Aqua) the free position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuildMagazine_Click(object sender, EventArgs e)
        {
            if(txtPositionsInMagazine.Text.Trim() != string.Empty)
            {
                _positionsInMagazine = int.Parse(txtPositionsInMagazine.Text.Trim());
                CreateMagazine(_positionsInMagazine);
                DefaultPositionsOccupation(_positionsInMagazine);
                afterMagazigeFormState();
                magazineToolStripStatus.Text = $"STATUS: A magazine with {_positionsInMagazine} positions has create*";
            }
            else
            {
                magazineToolStripStatus.Text = $"STATUS: Field must not be empty";
            }
        }

        #endregion 

        #region Button Action for find first free Position
        /// <summary>
        /// Find the first free Position
        /// Marked with Red of the Occupied Positions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            if (txtRequiredPositions.Text.Trim() != string.Empty)
            {
                int requiredPosition = int.Parse(txtRequiredPositions.Text.Trim());
                bool isRotary = rdbIsRotary.Checked ? true : false;

                int firstFreePosition = FindFreePlace(_places, isRotary, requiredPosition);

                if (firstFreePosition == -1)
                {
                    MessageBox.Show("No position is found : -1 ");
                    magazineToolStripStatus.Text = $"STATUS: No position is found : -1";
                }
                else
                {
                    MessageBox.Show($"First free Position found at {firstFreePosition}");
                    determineOccupiedPositions(firstFreePosition, requiredPosition, isRotary);
                    magazineToolStripStatus.Text = $"STATUS: First free Position found at: {firstFreePosition}";
                }
            }
            else
            {
                magazineToolStripStatus.Text = $"STATUS: Field must not be empty";
                txtRequiredPositions.Focus(); 
            }
        }

        #endregion

        #region Find Free Position and Change Position state, background color 

        /// <summary>
        /// Set Default value for Magazine Positions 
        /// Set background color for Fre Position in the Magazine
        /// </summary>
        /// <param name="totalPositions"></param>
        /// <returns></returns>
        public bool[] DefaultPositionsOccupation(int totalPositions)
        {
            _places = new bool[totalPositions]; 
            for(int i =0; i< totalPositions-1; i++)
            {
                _places[i] = false; 
            }

            foreach (Control c in magazinePanel.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.Aquamarine;
                }
            }
            return _places; 
        }

        /// <summary>
        /// Find the Free Positions in the Magazine
        /// </summary>
        /// <param name="places"></param>
        /// <param name="isRotary"></param>
        /// <param name="neededPlaces"></param>
        /// <returns></returns>
        public static int FindFreePlace(bool[] places, bool isRotary, int neededPlaces)
        {
            if (neededPlaces > places.Length)
                return -1; 

            var freePlaces = new List<int>();
            int rotationCount = 0; 
            for (int i = 0; i < places.Length; i++)
            {
                if (!places[i])
                {
                    freePlaces.Add(i);
                }
                else
                {
                    freePlaces.Clear();
                }

                if (freePlaces.Count == neededPlaces)
                {
                    return freePlaces[0];
                }

                // only one ratation if circular Magazine exists
                if (isRotary && i == places.Length - 1 && rotationCount < 1)
                {
                    // Iterate the loop again
                    i = -1; 
                    rotationCount++; 
                }
            }

            return -1;
        }

        /// <summary>
        /// Place all the occupied position in the Magazine 
        /// </summary>
        /// <param name="firstPosition"></param>
        /// <param name="requiredPosition"></param>
        /// <param name="isRotary"></param>
        void determineOccupiedPositions(int firstPosition, int requiredPosition, bool isRotary)
        {
            int lastPosition = 0;

            if (!isRotary)
            {
                lastPosition = firstPosition + requiredPosition;
                coloredOccupiedPosition(firstPosition, lastPosition);
            }
            else
            {
                lastPosition = firstPosition + requiredPosition;
                
                if (_positionsInMagazine < lastPosition)
                {
                    coloredOccupiedPosition(firstPosition, _positionsInMagazine);
                    coloredOccupiedPosition(0, lastPosition - _positionsInMagazine);
                }
                else coloredOccupiedPosition(firstPosition, lastPosition);
            }            
        }

        /// <summary>
        /// Change default state of the position and also change background to red
        /// </summary>
        /// <param name="fPostion"></param>
        /// <param name="lPostion"></param>
        void  coloredOccupiedPosition(int fPostion, int lPostion)
        {
            var markPositions = new List<int>();
            for (int i = fPostion; i < lPostion; i++)
            {
                markPositions.Add(i);
                _places[i] = true;
            }

            foreach (Control c in magazinePanel.Controls)
            {
                if (c is Button)
                {
                    if (markPositions.Contains(c.TabIndex))
                        c.BackColor = Color.Red;
                }
            }
        }
        
        #endregion

        #region Methond for Magazine creation

        /// <summary>
        /// Create the magazine and represents each position using Button 
        /// </summary>
        /// <param name="positionsInMagazine"></param>
        void CreateMagazine(int positionsInMagazine)
        {
           
            int X = 0;
            int Y = 0;
            int posWidth = 0;
            for (int i = 0; i < positionsInMagazine; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Size = new Size(40, 40);
                posWidth = 40 * (X + 1);
                btn.Location = new Point(40 * (X + 1), 40);
                X++;              
                magazinePanel.Controls.Add(btn);
                magazineToolStripStatus.Text = $"STATUS: {positionsInMagazine} positions in the magazine has created";                 
            }
        }

        #endregion

        #region Occupy random Position 
        /// <summary>
        /// To create complex scenario, User can set a single Position to occupied.
        /// Just input a number, button action will occupy it. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOccupied_Click(object sender, EventArgs e)
        {
            if(txtRandomPosition.Text.Trim() != string.Empty)
            {
                int randomPosition = int.Parse(txtRandomPosition.Text.Trim());
                setRandonPosition(randomPosition);
            }
            else
            {
                magazineToolStripStatus.Text = $"STATUS: Field must not be empty";
                txtRandomPosition.Focus(); 
            }
        }

        void setRandonPosition(int randomPosition)
        {
            if (randomPosition < _positionsInMagazine)
            {
                if (!_places[randomPosition])
                {
                    _places[randomPosition] = true;
                    determineOccupiedPositions(randomPosition, 1, false);
                    magazineToolStripStatus.Text = $"STATUS: Randon position {randomPosition} has occupied";
                }
                else
                {
                    MessageBox.Show("Already Occupied");
                }
            }
            else
            {
                MessageBox.Show("Position must not exceed the max position in magazine ");
                magazineToolStripStatus.Text = $"STATUS:  Position must not exceed the max position in magazine";
            }
        }

        #endregion

        #region Textbox will take Only Integer

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtPositionsInMagazine_KeyPress(object sender, KeyPressEventArgs e)
        {
            typeOnlyInteger(sender, e);
        }

        private void txtRandomPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            typeOnlyInteger(sender, e);
        }

        private void txtRequiredPositions_KeyPress(object sender, KeyPressEventArgs e)
        {
            typeOnlyInteger(sender,e); 
        }

        private void typeOnlyInteger(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Reset

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRandomPosition.Text = "";
            txtPositionsInMagazine.Text = "";
            txtRequiredPositions.Text = "";
            magazinePanel.Controls.Clear();
            beforeMagazigeFormState();
        }
        private void beforeMagazigeFormState()
        {
            grpFindPosition.Enabled = false;
            grpRandomPosition.Enabled = false;
            btnReset.Enabled = false;
        }

        private void afterMagazigeFormState()
        {
            grpFindPosition.Enabled = true;
            grpRandomPosition.Enabled = true;
            btnReset.Enabled = true;

        }

        #endregion
    }
}
