using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COSI_Lab3
{

    public partial class Form1 : Form
    {
        private void elementRotateDisable()
        {
            labelRotate.Enabled = false;
            trackBarRotate.Enabled = false;
            buttonRotate.Enabled = false;
        }
        private void elementRotateEnable()
        {
            labelRotate.Enabled = true;
            trackBarRotate.Enabled = true;
            buttonRotate.Enabled = true;
        }
        private void elementWaveEnable()
        {
            trackBarV1.Enabled = true;
            trackBarV2.Enabled = true;
            trackBarV3.Enabled = true;
            trackBarV4.Enabled = true;
            buttonWave.Enabled = true;
        }
        private void elementWaveDisable()
        {
            trackBarV1.Enabled = false;
            trackBarV2.Enabled = false;
            trackBarV3.Enabled = false;
            trackBarV4.Enabled = false;
            buttonWave.Enabled = false;
        }


        private void enableOtherButtons()
        {
            buttonNegative.Enabled = true;
            saveImage.Enabled = true;
            buttonToGray.Enabled = true;
            blurButton.Enabled = true;
            trackBarBlur.Enabled = true;
        }
        private void disableOtherButtons()
        {
            buttonNegative.Enabled = false;
            saveImage.Enabled = false;
            buttonToGray.Enabled = false;
            blurButton.Enabled = false;
            trackBarBlur.Enabled = false;
        }
        private void enableMirroring()
        {
            buttonReverseGorizontal.Enabled = true;
            buttonReverseVertical.Enabled = true;
        }
        private void disableMirroring()
        {
            buttonReverseGorizontal.Enabled = false;
            buttonReverseVertical.Enabled = false;
        }

        private void drawElementsEnable()
        {
            enableOtherButtons();
            elementRotateEnable();
            elementWaveEnable();
            enableMirroring();
        }
        private void drawElementsDisable()
        {
            disableOtherButtons();
            elementRotateDisable();
            elementWaveDisable();
            disableMirroring();

        }









    }
}