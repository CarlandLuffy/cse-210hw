using System;
using System.Collections.Generic;

// Developer: Carl Hylton
// Course: CSE 210 – Programming with Classes
// Week 12 – Final Project Milestone (Foundation 4)
//
// Progress Update:
// For this milestone, I completed the first two Foundation programs.
// Program 1 (Abstraction) includes the Video and Comment classes,
// with methods to display video information and all associated
// comments. Program 2 (Encapsulation) includes the Product,
// Customer, Address, and Order classes, with methods for calculating
// totals, generating packing and shipping labels, and determining
// domestic vs. international shipping.

using System;
using System.Collections.Generic;

namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video video1 = new Video("Luffy vs Kaido", "One Piece Channel", 1200);

            // ✅ UPDATED: use AddComment() (instead of video1.Comments.Add)
            video1.AddComment(new Comment("ZoroFan", "This fight is insane!"));
            video1.AddComment(new Comment("NamiLover", "The animation is so good."));
            video1.AddComment(new Comment("UsoppGod", "I watched this 5 times."));

            Video video2 = new Video("How to Use Haki", "Rayleigh", 600);
            video2.AddComment(new Comment("Luffy", "Thanks old man!"));
            video2.AddComment(new Comment("Kid", "Wish I learned this earlier."));
            video2.AddComment(new Comment("Law", "Very helpful."));

            Video video3 = new Video("Cooking with Sanji", "Baratie Kitchen", 900);
            video3.AddComment(new Comment("Zoro", "I only came for the food."));
            video3.AddComment(new Comment("Nami", "Looks delicious!"));
            video3.AddComment(new Comment("Chopper", "So cool!"));

            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            for (int i = 0; i < videos.Count; i++)
            {
                Video video = videos[i];
                video.DisplayVideoDetails();
            }
        }
    }
}

