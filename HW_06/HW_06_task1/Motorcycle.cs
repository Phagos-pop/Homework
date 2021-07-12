using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06_task1_AssemblyOne
{
    public class Motorcycle
    {
        const ushort maxSpeed = 280;
        string vinNumber = "1548926va";
        int odoMetr = 20_000;

        public ushort maxSpeedPublic = 280;
        private string vinNumberPrivat = "1548926va";
        protected int odoMetrProtected = 20_000;
        internal ushort maxSpeedINternal = 280;
        protected internal string vinNumberProtectedInternal = "1548926VA";
        private protected int odoMetrPrivateProtected = 20_000;

        void StartEngine()
        {

        }
        private void CheckFuelPrivate()
        {

        }
        public void StopEnginePublic()
        {

        }
        protected void AccelerateProtected()
        {

        }
        internal void SlowDownInternal()
        {

        }
        protected internal void StopInPlaceProtectedInternal()
        {

        }
        private protected void StartPrivateProtected()
        {

        }
    }
}
