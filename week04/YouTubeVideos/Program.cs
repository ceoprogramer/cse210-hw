using System;

class Program
    {
        static void Main(string[] args)
        {
            // 1. Video list
            List<Video> videos = new List<Video>();

            // --- VIDEO 1 ---
            Video video1 = new Video("How learn C# in 10 minutes", "ProgrammerPro", 600);
            video1.AddComment(new Comment("John Pratz", "¡Excelent video!"));
            video1.AddComment(new Comment("Maria G.", "I learned a lot from this video."));
            video1.AddComment(new Comment("Lucas88", "This video worked a lot for my exam"));
            videos.Add(video1);

            // --- VIDEO 2 ---
            Video video2 = new Video("Review of new iPhone 15", "TechMaster", 900);
            video2.AddComment(new Comment("Santi_Tech", "It looks like in color titanio."));
            video2.AddComment(new Comment("Carla V.", "I prefer to wait for the next year."));
            video2.AddComment(new Comment("User99", "Too expensive for what it is."));
            videos.Add(video2);

            // --- VIDEO 3 ---
            Video video3 = new Video("Recipe of Authentic Carbonara Pasta", "ChefItaliano", 450);
            video3.AddComment(new Comment("Luigi", "¡Mamma mia! Well done."));
            video3.AddComment(new Comment("Sofía", "I made it today and it was delicious."));
            video3.AddComment(new Comment("Hater101", "I used cream and taste better."));
            video3.AddComment(new Comment("CocineroAmateur", "Thanks for the cheese tip."));
            videos.Add(video3);

            // 2. Iterar y mostrar la información
            foreach (var video in videos)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"TITLE: {video._title}");
                Console.WriteLine($"AUTOR: {video._author}");
                Console.WriteLine($"DURATION: {video._lengthInSeconds} seconds");
                Console.WriteLine($"NUMBER OF COMMENTS: {video.GetCommentCount()}");
                Console.WriteLine("\nCOMMENTS:");

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.Name}: \"{comment.Text}\"");
                }
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }