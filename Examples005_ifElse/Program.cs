Console.WriteLine("Введите имя пользователя: ");
String userName = Console.ReadLine();
if(userName.ToLower() == "андрей"){
    Console.WriteLine("Ураа! Это же " + userName +".");
} else{
    Console.WriteLine("Привет, " + userName +".");
}

