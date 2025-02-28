namespace PartnerProject.Models
{
    public class MultipleChoiceQuestion
    {
        public string Question { get; set; } = string.Empty;
        public List<string> Choices { get; set; } = new();
        public int UserChoice { get; set; }
        public int QuestionAnswer { get; set; }

        public int amount { get; set; } = 0;
    }
}
