using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");

        List<Video> _videos = new List<Video>();

        //Creating new Video
        Video video1 = new Video("Coding in C#", "Robert Smith", 400);

        //comments on the Video1 using large code

        Comment comment1 = new Comment("Paul Snider", "Great Video, It help me a lot.");
        Comment comment2 = new Comment("Jose Perez", "Super Video, I learn a lot. ");
        Comment comment3 = new Comment("Maria Delgado", "Super Interesting Video, It help me on my classes. ");


        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        _videos.Add(video1);


        //Adding Video2, in this case I will use a short code for comments.
        Video video2 = new Video("Python for dummies", "Francisco Lopez", 500);

        //adding Comments on the video2, short way

        video2.AddComment(new Comment("Pedro Garcia", "Thank you for share your knowledge"));
        video2.AddComment(new Comment("Maria Morris", "Great video so far, I would like to see the next one"));

        _videos.Add(video2);


        //Adding Video3, in this case I will use a short code for comments.
        Video video3 = new Video("Programming with Classes", "John Reading", 700);

        //adding Comments on the video2, short way
        video3.AddComment(new Comment("Carlos Poma", "This video is great, I learn how I can start programming with classes"));
        video3.AddComment(new Comment("Hector Garcia", "Great! Thank you for the video. It is amazing"));
        video3.AddComment(new Comment("Ruben Palomino", "Wonderfull video."));
        video3.AddComment(new Comment("Maria Regalado", "Sincerelly the best video ever."));

        _videos.Add(video3);






        foreach (Video video in _videos)
        {
            video.Display();
        }

    }
}