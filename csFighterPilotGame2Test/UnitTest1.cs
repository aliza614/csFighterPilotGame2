using csFighterPilotGame2;
using Shouldly;
using System.Windows.Forms;

namespace csFighterPilotGame2Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase (1,1,2,2,3,3)]
        public void Inputs_PictureBox_deltaX_deltaY_MovePB_Outputs_none_Outcome_pbTop_and_pbLeft_changed(int inX, int inY,int deltaX, int deltaY, int outX, int outY) 
        {
            PictureBox pb = new PictureBox()
            {
                Left = inX,
                Top = inY
            };
            Form1.MovePB(pb, deltaX, deltaX);
            pb.Left.ShouldBe(outX);
            pb.Top.ShouldBe(outY);
        }
        [Test]
        [TestCase("block",0,0,"block")]
        public void Inputs_X_Y_Tag_generatesPB_Outputs_PictureBox(/*Generated based on the tag-int inX, int inY, */string inTag, int outX, int outY, string outTag)
        {
            // for if it's a block ammorefill coin ->Random random = new Random();
            PictureBox pb=Form1.generatesPB
            switch (inTag)
            {
                case "block": 

            }
        }
    }
}