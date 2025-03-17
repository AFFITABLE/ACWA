using System.ComponentModel.DataAnnotations;

namespace QUIZARTZ.Models
{
    public class Testquiz
    {

        [Key]
        public int QuestionId { get; set; }
       

        public string question { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
        public string? rightans { get; set; }
        public int score { get; set; }
                

    }
}
