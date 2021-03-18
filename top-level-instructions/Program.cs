using System;
using System.Threading.Tasks;

static string GetAnswer()
{
  string[] answers =
  {
    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
  };

  var rand = new Random();
  var index = rand.Next(answers.Length - 1);

  return answers[index];
}

static async Task RunAnimation()
{
  foreach (string s in new[] { "| -", "/ \\", "- |", "\\ /", })
  {
      Console.Write(s);
      await Task.Delay(50);
      Console.Write("\b\b\b");
  }
  Console.WriteLine();
}

static void RunAnswer()
{
  Console.WriteLine(GetAnswer());
  Console.WriteLine();
}

static void RunQuestion(string[] args)
{
  Console.WriteLine(string.Join(" ", args));
  Console.WriteLine();
}

static async Task Run(string[] args)
{
  RunQuestion(args);
  await RunAnimation();
  RunAnswer();
}

await Run(args);