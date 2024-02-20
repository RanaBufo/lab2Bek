using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

var service = new ServiceCollection();
service.AddMyService();
using var serviceProvider = service.BuildServiceProvider();
var validator = serviceProvider.GetService<IValid>();
var userInput = serviceProvider.GetService<UserDataInput>();

string? name = userInput?.GetName();
string? surname = userInput?.GetSurname();
string? phone = userInput?.GetPhone();
string? email = userInput?.GetEmail();
string? post = userInput?.GetPost();
string? password = userInput?.GetPassword();
string? duplicatePassword = userInput?.GetDuplicatePassword();




Console.WriteLine($"Is name '{name}' valid: {validator?.IsValidName(name)}");
Console.WriteLine($"Is surname '{surname}' valid: {validator?.IsValidSurname(surname)}");
Console.WriteLine($"Is phone number '{phone}' valid: {validator?.IsValidPhone(phone)}");
Console.WriteLine($"Is email '{email}' valid: {validator?.IsValidEmail(email)}");
Console.WriteLine($"Is postal code '{post}' valid: {validator?.IsValidPost(post)}");
Console.WriteLine($"Is password '{password}' valid: {validator?.IsValidPassword(password)}");
Console.WriteLine($"Are passwords matching: {validator?.IsValidDuplicatePassword(password, duplicatePassword)}");
