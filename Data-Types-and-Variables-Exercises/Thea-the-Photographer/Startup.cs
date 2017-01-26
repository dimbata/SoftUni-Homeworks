using System;

public class Startup
{
    public static void Main()
    {
        /*
         *  Thea is a photographer. She takes pictures of people on special events. She is a good friend and you want to help her.
            She wants to inform her clients when their pictures will be ready. Since the number of pictures is big and it requires time for editing (#nofilter, #allnatural) every single picture - you decide to write a program in order to help her.
            Thea follows this pattern: first she takes all pictures. Then she goes through every single picture to filter these pictures that are considered "good". Then she needs to upload every single filtered picture to her cloud. She is considered ready when all filtered pictures are uploaded in her picture storage.
            You will receive the amount of pictures she had taken. Then the approximate time in seconds for every picture to be filtered. Then a filter factor – a percentage (integer number) of the total photos (rounded to the nearest bigger integer value e.g. 5.01 -> 6) that are good enough to be given to her clients (Photoshop may do miracles but Thea does not). Approximate time for every picture to be uploaded will be given again in seconds. Your task is: based on this input to display total time needed for her to be ready with the pictures in given below format.
            Input
            On the first line you will receive an integer N – the amount of pictures Thea had taken.
            On the second line you will receive an integer FT – the amount of time (filter time) in seconds that Thea will require to filter every single picture.
            On the third line you will receive an integer FF – the filter factor or the percentage of the total pictures that are considered “good” to be uploaded.
            On the fourth line you will receive an integer UT – the amount of time needed for every filtered picture to be uploaded to her storage.
            The input will be in the described format, there is no need to check it explicitly.
         */

        int N = int.Parse(Console.ReadLine());
        int FT = int.Parse(Console.ReadLine());
        int FF = int.Parse(Console.ReadLine());
        int UT = int.Parse(Console.ReadLine());

        long secondsToCheckAllPhotos = N * FT;
        int filteredPictures = (int)Math.Ceiling(N * (FF / 100.0));
        long secondsToUploadGoodPhotos = filteredPictures * UT;
        long fullTime = secondsToCheckAllPhotos + secondsToUploadGoodPhotos;

        int seconds = (int)fullTime % 60;
        int minutes = (int)((fullTime / 60)%60);
        int hours = (int)((fullTime / 3600)%3600);
        int days = (int)((fullTime / (3600 * 24))%(3600*24));

        Console.WriteLine(days.ToString("0") + ":" + hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00"));
        Console.WriteLine(TimeSpan.FromSeconds(fullTime).ToString(new string('d',1) + @"\:hh\:mm\:ss"));
    }
}

