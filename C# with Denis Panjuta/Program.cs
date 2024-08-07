// Simple Little Quiz App

string question1 = "What is the capital city of Macedonia?";
string answer1 = "Skopje";

string question2 = "What is 2+2*3?";
string answer2 = "8";

string question3 = "Who won the EURO 2024?";
string answer3 = "Spain";

int score = 0;

Console.WriteLine(question1);
string userAnswer = Console.ReadLine();

if(userAnswer.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}else
{
    Console.WriteLine($"Wrong,the correct answer is: {answer1}");
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();

if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine($"Wrong,the correct answer is: {answer2}");
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();

if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine($"Wrong,the correct answer is: {answer3}");
}

Console.WriteLine($"Quiz completed! Your final score is : {score}/3");
if(score == 3)
{
    Console.WriteLine("Excellent!You got all the answers right!");
}else if(score > 0)
{
    Console.WriteLine("Good Job,but keep learning");
}else
{
    Console.WriteLine("Try Again!");
}

Console.ReadLine();
