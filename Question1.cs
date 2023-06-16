using System;

namespace ReizTech_InternExam;

internal static class Question1 {
    private static void Main() {
        Console.WriteLine("Reiz Tech Intern Exam - Question 1");
        Console.WriteLine("==================================");
        Console.Write("Enter the hours (0-12): ");
        var hours = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        Console.Write("Enter the minutes (0-59): ");
        var minutes = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        // Because the hour hand completes a full rotation (360 degrees) every 12 hours(720 minutes)
        // Which means that the hour hand moves 0.5 degrees per minute (360 / 720)
        // To calculate the angle of the hour hand, we multiply the number of hours by 60 and add the number of minutes
        // Then multiply the result by 0.5 to get the angle covered by the hour hand
        var hourAngle = 0.5 * (hours * 60 + minutes);
        
        // Because the minute hand completes a full rotation (360 degrees) every 60 minutes
        // Which means that the minute hand moves 6 degrees per minute (360 / 60)
        // To get the angle covered by the minute hand, we multiply the number of minutes by 6
        double minuteAngle = 6 * minutes;

        // In order to get the smaller angle between the hour and minute hands
        // We need to get the absolute difference between the two angles
        var angle = Math.Abs(hourAngle - minuteAngle);
        
        // However, since an analog clock is cyclical and the hands can be on either side of the clock
        // We need to consider the smaller angle between the two angles
        // We compare the difference between the two angles and 360 - the difference
        // And get the smaller of the two
        angle = Math.Min(360 - angle, angle);

        // ReSharper disable once HeapView.BoxingAllocation
        Console.WriteLine($"The smaller angle between the hour and minute hands is: {angle} degrees.");
        
        // This was a very interesting question, I enjoyed it a lot!
    }
}