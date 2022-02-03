using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
    class Youtuber : Creator  //Inheriting the class and overriding the methods
    {
        public override void Create()
        {
            if(base.CreativityLevel >= 50 && base.Energy >= 50)
            {
                this.VideoIdeas();
                this.CreateScript();
                this.VideoTapeScript();
                this.EditVideo();
                this.Rendervideo();
            }
            else
            {
                Console.WriteLine("Cannot create a video");
            }
        }
        private void VideoIdeas()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Video Ideas......");
        }
        private void CreateScript()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Creating a video Script......");
        }
        private void VideoTapeScript()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Videotaping myself executing script......");
        }
        private void EditVideo()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.Energy - 5;
            Console.WriteLine("Editing the video......");
        }
        
        private void Rendervideo()
        {
            base.CreativityLevel = base.CreativityLevel - 1;
            base.Energy = base.Energy - 1;
            Console.WriteLine("Rendering the video.....");
        }
    }
}
