using ChainOfResponsibilityDP.Entity;
using System;

namespace ChainOfResponsibilityDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video();
            Video video2 = new Video();
            Video video3 = new Video();
            //Request
            video1.Link = "https://www.youtube.com/watch?v=IKRVX3c8HuU";
            video2.Link = "https://www.facebook.com/watch/?v=361268888540894";
            //Handlers
            YoutubHandler youtubHandler = new YoutubHandler();
            FacebookHandler facebookHandler = new FacebookHandler();
            InstagramHandler instagramHandler = new InstagramHandler();
            //chain
            youtubHandler.setNextHandler(facebookHandler);
            facebookHandler.setNextHandler(instagramHandler);
            youtubHandler.HandleRequest(video2);
            Console.WriteLine();
            Console.WriteLine();
            facebookHandler.HandleRequest(video2);
            //Usages 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
           
            Usages.tryCatchBloks();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
