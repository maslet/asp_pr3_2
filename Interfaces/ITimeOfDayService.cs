namespace usov_402_pr3_part2.Interfaces {
    public interface ITimeOfDayService {
        string GetTimeOfDayMessage();
    }

    public class TimeOfDayService : ITimeOfDayService {
        public string GetTimeOfDayMessage() {
            var currentTime = DateTime.Now.Hour;
            if (currentTime >= 12 && currentTime < 18)
                return "зараз день";
            if (currentTime >= 18 && currentTime < 24)
                return "зараз вечір";
            if (currentTime >= 0 && currentTime < 6)
                return "зараз ніч";
            return "зараз ранок";
        }
    }

}
