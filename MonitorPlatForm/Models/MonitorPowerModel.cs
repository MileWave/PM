using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thorlabs.PM100D_64.Interop;

using System.Windows.Forms;

namespace MonitorPlatForm.Models
{
    class MonitorPowerModel
    {
        /// <summary>
        /// Monitor power construct with Device Name
        /// </summary>
        public MonitorPowerModel(string name, double wavelen, double pow)
        {

            pm = new PM100D(name, true, true);
            waveLength = waveLength;
            power = pow;
        }

        private PM100D pm;
        private string PMDeviceName;
        private double waveLength;
        private double power;

        public enum ScanSteps
        {
            PPLNTANDLDC = 1,
            PPLNT,
            LDC
        }

        public enum ScanModePPLNT
        {
            LDCUPANDDOWN = 1,
            LDCUP,
            LDCDOWN

        }

        public enum ScanModeLDC
        {
            PPLNTUPANDDOWN = 1,
            PPLNTUP,
            PPLNTDOWN
        }

        public string sPPLNT
        {
            get { return _dPPLNT.ToString(); }
            
            /*
            set { if(Double.Parse(value) 
                    _dPPLNT = Convert.ToDouble(value);
                    
            }
             * */
            set{
                if (Double.TryParse(value, out _dd))
                {
                    if (_dd > 110 || _dd < 25)
                    {
                        MessageBox.Show("PPLN temperature Over Range: 25-110");
                        //_dPPLNT = 25;
                    }
                    else
                    {
                        _dPPLNT = _dd;
                        //_dPPLNT = Convert.ToDouble(value);
                        //MessageBox.Show("PPLN temperature can not be set.");
                    }
                    
                }
                else
                {

                    MessageBox.Show("Cannot Set PPLN temperature");
                }

            }

        }


        public string sPPLNTUP
        {
            get { return _dPPLNTUP.ToString(); }
            set{
                if (double.TryParse(value, out _dd))
                {
                    if (_dd > 110 || _dd < 25)
                    {
                        MessageBox.Show("PPLN temperature Over Range: 25-110");
                        //_dPPLNTUP = 25;
                    }
                    else
                    {
                        _dPPLNTUP = _dd;
                    }
                    //MessageBox.Show("Cannot Set PPLN up temperature");
                }
                else
                {
                    MessageBox.Show("Cannot Set PPLN up temperature");
                }
            }
        }

        public string sPPLNTDOWN
        {
            get { return _dPPLNTDOWN.ToString(); }
            set{
                if (double.TryParse(value, out _dd))
                {
                    //MessageBox.Show("Cannot Set PPLN down temperature");
                    if (_dd > 110 || _dd < 25)
                    {
                        MessageBox.Show("PPLN temperature Over Range: 25-110");
                        //_dPPLNTUP = 25;
                    }
                    else
                    {
                        _dPPLNTDOWN = _dd;
                    }
                    //MessageBox.Show("Cannot Set PPLN up temperature");
                }
                else
                {
                    MessageBox.Show("Cannot Set PPLN up temperature");
                }
            }
        }

        public string sLDC
        {
            get { return _dLDC.ToString(); }
            set{
                if (double.TryParse(value, out _dd))
                {
                    //MessageBox.Show("Cannot Set LD current");
                    if(_dd > 22.0)
                    {
                        MessageBox.Show("LD Current Over Range: 25-110.");
                    }
                    else{
                        _dLDC = _dd;
                    }
                }
                else
                {
                    MessageBox.Show("Cannot Set LD Current");
                }
            }
        }

        public string sLDCUP
        {
            get { return _dLDCUP.ToString(); }
            set{
                if (double.TryParse(value, out _dd))
                {
                    // MessageBox.Show("Cannot Set LD up current");

                    //MessageBox.Show("Cannot Set LD current");
                    if (_dd > 22.0)
                    {
                        MessageBox.Show("LD Current Over Range: 25-110.");
                    }
                    else
                    {
                        _dLDCUP = _dd;
                    }
                }
                else
                {
                    MessageBox.Show("Cannot Set LD Current Up");
                }
            }
        }

        public string sLDCDOWN
        {
            get { return _dLDCDOWN.ToString(); }
            set{
                if (double.TryParse(value, out _dd))
                {
                    // MessageBox.Show("Cannot Set LD up current");

                    //MessageBox.Show("Cannot Set LD current");
                    if (_dd > 22.0)
                    {
                        MessageBox.Show("LD Current Over Range: 25-110.");
                    }
                    else
                    {
                        _dLDCDOWN = _dd;
                    }
                }
                else
                {
                    MessageBox.Show("Cannot Set LD Current Down");
                }

            }
        }


        private double _dPPLNT;
        private double _dPPLNTUP;
        private double _dPPLNTDOWN;
        private double _dLDC;
        private double _dLDCUP;
        private double _dLDCDOWN;
        private double _dd;

    }
}
