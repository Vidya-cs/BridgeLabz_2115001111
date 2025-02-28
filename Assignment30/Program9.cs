using System;

//custom attribute
[AttributeUsage(AttributeTargets.Property)]
class MaxLengthAttribute : Attribute{
    public int MaxLength {set; get;}
    public MaxLengthAttribute(int maxLength){
        MaxLength = maxLength;
    }
}

class User{
    [MaxLength(10)]
    public string Username { get; set; }
    public User(string username){
        if(username.Length>10){
            throw new ArgumentException("Username exceeds the maximum length");
        }
        Username = username;
    }
}

class Program9{
    public static void Main(string[] args){
        try{
            User user = new User("Vidya Sagar Singh");
        }
        catch (Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}
