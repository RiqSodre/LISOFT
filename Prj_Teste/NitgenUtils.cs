using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NITGEN.SDK.NBioBSP;
using System.Windows.Forms;

namespace PrjManut
{
    class NitgenUtils
    {
        private NBioAPI nBioApi = null;

        public NitgenUtils()
        {
            nBioApi = new NBioAPI();
        }

        public void Inicializar()
        {
            uint ret = nBioApi.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            if (ret == NBioAPI.Error.NONE)
                return;
            else
                throw new Exception();
        }

        public void Finalizar()
        {
            uint ret = nBioApi.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            if (ret == NBioAPI.Error.NONE)
                return;
            else
                throw new Exception();
        }

        public void CadastrarDigital() //Enroll
        {
            NBioAPI.Type.FIR biFIR = null;
            NBioAPI.Type.HFIR newFIR = null;
            Inicializar();
            uint ret = nBioApi.Enroll(out newFIR, null);

            if (ret == NBioAPI.Error.NONE)
            {
                nBioApi.GetFIRFromHandle(newFIR, out biFIR);
            }
            Finalizar();
        }

        public bool VerificarDigitais(NBioAPI.Type.FIR userFRI)
        {
            uint ret;
            bool result;

            ret = nBioApi.Verify(userFRI, out result, null);

            if(ret != NBioAPI.Error.NONE)
            {
                throw new Exception();
            }

            return result;
        }
    }
}
