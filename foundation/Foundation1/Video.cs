public class Video{

public string _title;
public string _author;
public int _length;
public List<Comments> _comments = new List<Comments>();



public int GetNumberComment(int number){

    number= _comments.Count;

    return number; 
}

public void Display(){

Console.WriteLine($"{_title}");
Console.WriteLine($"{_author}");

foreach(Comments comment in _comments)
{

comment.ShowComment();


}

}



} 