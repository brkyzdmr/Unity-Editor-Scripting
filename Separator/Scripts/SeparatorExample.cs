using UnityEngine;

public class SeparatorExample : MonoBehaviour {

    [Separator("Cover")]
    public string bookName = "2050";
    public string authorName = "David Passig";
    [Separator("Attributes")]
    public int numOfPages = 387;
    [Separator("")]
    [Range(1,5)]
    public int point = 5;




}
