using System;

class Reference
{
    private string book, chapter, verseStart, verseEnd;

    public Reference(string _book, string _chapter, string _verse)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verse;
    }

    public Reference (string _book, string _chapter, string _verseStart, string verseEnd)
    {

    }




    public string GetReference()
    {
        if (verseEnd == "")
        {
            return ($"{book} {chapter}: {verseStart}");
        }

        else
        {
            return ($"{book} {chapter}: {verseStart} - {verseEnd}");
        }
    }
}