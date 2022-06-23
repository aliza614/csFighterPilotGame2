using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csFighterPilotGame2
{
    public class Block : PictureBox,IPB
    {
        public bool Intersects(PictureBox pb2)
        {
            throw new NotImplementedException();
        }
    }
}
