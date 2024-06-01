using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video vid1 = new Video("Mysteries of the Universe", "Now Next", 624);

        Comment vid1Comment1 = new Comment("Jennie", "This was a great video! very helpful!");
        Comment vid1Comment2 = new Comment("Yulissa", "This channel might be one of the best thing that has ever happen");
        Comment vid1Comment3 = new Comment("Antonio", "This video is excellent for all age!");

        vid1.AddComment(vid1Comment2);
        vid1.AddComment(vid1Comment3);
        vid1.AddComment(vid1Comment1);

        videoList.Add(vid1);


        Video vid2 = new Video("The best way to play with a puppy", "Animal Wised", 2457);

        Comment vid2Comment1 = new Comment("Ale", "I love hide and seek and seeing them work for reward!");
        Comment vid2Comment2 = new Comment("Jessie", "This video is so cute, I love it");
        Comment vid2Comment3 = new Comment("Lucas", "I learn a lot of this video!");

        vid2.AddComment(vid2Comment2);
        vid2.AddComment(vid2Comment3);
        vid2.AddComment(vid2Comment1);

        videoList.Add(vid2);

        Video vid3 = new Video("Top 15 things to see and do in Bora Bora", "Travel Max", 34567);

        Comment vid3Comment1 = new Comment("Nancy", "The most beautiful place");
        Comment vid3Comment2 = new Comment("Mike", "Amazing video");
        Comment vid3Comment3 = new Comment("Angie", "Bora Bora is a paradise!");

        vid3.AddComment(vid3Comment2);
        vid3.AddComment(vid3Comment3);
        vid3.AddComment(vid3Comment1);

        videoList.Add(vid3);


        foreach (Video video in videoList)
        {
            video.DisplayComments();
            Console.WriteLine("--------------------");
        }
    }

}
