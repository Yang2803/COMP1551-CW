using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public enum QuestionType
{
    MultipleChoice,
    OpenEnded,
    TrueFalse
}

public abstract class BaseQuestion
{
    public string Text { get; set; }
    public QuestionType Type { get; protected set; }

    public BaseQuestion(string text)
    {
        Text = text;
    }

    // 🔹 Abstract method để đánh giá đáp án
    public abstract bool CheckAnswer(string userAnswer);

    public override string ToString()
    {
        return Text;
    }


    private static readonly Dictionary<string, string> answerAlias = new Dictionary<string, string>
    {
        { "uk", "united kingdom" },
        { "united kingdom", "united kingdom" },
        { "usa", "united states" },
        { "united states", "united states" },
        { "viet nam", "vietnam" },
        { "vietnam", "vietnam" },
        { "ho chi minh city", "saigon" },
        { "saigon", "saigon" }
    };

    
    public static string Normalize(string input)
    {
        string cleaned = string.Join(" ", input.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        return answerAlias.TryGetValue(cleaned, out string mapped) ? mapped : cleaned;
    }
}

public class MultipleChoiceQuestion : BaseQuestion
{
    public List<string> Options { get; set; }
    public int CorrectOptionIndex { get; set; }

    public MultipleChoiceQuestion(string text, List<string> options, int correctIndex)
        : base(text)
    {
        if (options == null || options.Count < 4)
            throw new ArgumentException("Multiple choice must have at least 4 options.");
        if (correctIndex < 0 || correctIndex >= options.Count)
            throw new ArgumentException("Correct answer index is invalid.");

        Options = options;
        CorrectOptionIndex = correctIndex;
        Type = QuestionType.MultipleChoice;
    }

    public override bool CheckAnswer(string userAnswer)
    {
        return int.TryParse(userAnswer, out int index) && index == CorrectOptionIndex;
    }
}

public class TrueFalseQuestion : BaseQuestion
{
    public bool TrueFalseAnswer { get; set; }

    public TrueFalseQuestion(string text, bool answer)
        : base(text)
    {
        TrueFalseAnswer = answer;
        Type = QuestionType.TrueFalse;
    }

    public override bool CheckAnswer(string userAnswer)
    {
        return bool.TryParse(userAnswer, out bool parsedAnswer) && parsedAnswer == TrueFalseAnswer;
    }
}

// 🔸 Open-Ended Question
public class OpenEndedQuestion : BaseQuestion
{
    public List<string> AcceptableAnswers { get; set; }

    public OpenEndedQuestion(string text, List<string> acceptableAnswers)
        : base(text)
    {
        AcceptableAnswers = acceptableAnswers ?? new List<string>();
        Type = QuestionType.OpenEnded;
    }

    public override bool CheckAnswer(string userAnswer)
    {
        return AcceptableAnswers.Exists(ans => ans.Equals(userAnswer, StringComparison.OrdinalIgnoreCase));
    }
}