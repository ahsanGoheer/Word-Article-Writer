using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;// For Creating Xml File.
using System.IO; // For Directory.
using word = Microsoft.Office.Interop.Word;// Needed to access MS Word.
namespace Utils
{
    public static class Writer
    {   
        public static void createTheXml(string FileName,string PostTitle,string ImageUrl,string article )
        {
            string cwd = Directory.GetCurrentDirectory(); //Gets the current working directory.
            using (XmlWriter xmlObj= XmlWriter.Create(Path.Combine(cwd,FileName)))
            {
                xmlObj.WriteStartDocument();
                xmlObj.WriteStartElement("articlebody");
                xmlObj.WriteAttributeString("title", PostTitle);
                xmlObj.WriteAttributeString("imagepath", ImageUrl);
                xmlObj.WriteAttributeString("article",article);
                xmlObj.WriteEndElement();
                xmlObj.WriteEndDocument();
                xmlObj.Close();
            }    
        }

        public static void createWordDoc(string FileName, string PostTitle, string ImageUrl, string article)
        {
            //Initializing the Microsoft Word Application.
            word.Application wordApp = new word.Application();
            wordApp.Visible = true;

            //Creating the Word Document.
            word.Document wordDoc = wordApp.Documents.Add();

            //Adding the Post Title to the Document.
            word.Paragraph title = wordDoc.Content.Paragraphs.Add();
            object headingStyle = "Heading 1";
            title.Range.set_Style(ref headingStyle);
            title.Range.Text = PostTitle;
            title.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
        

            //For adding image to the document.
            word.Paragraph image = wordDoc.Content.Paragraphs.Add();
            image.Range.Application.Selection.InlineShapes.AddPicture(ImageUrl);
            image.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
        

            //For adding article to the document.
            word.Paragraph mainarticle = wordDoc.Content.Paragraphs.Add();
            mainarticle.Range.Text = article;
            mainarticle.Alignment = word.WdParagraphAlignment.wdAlignParagraphJustify;
            string cwd = Directory.GetCurrentDirectory(); //Gets the current working directory.
            object filename = Path.Combine(cwd, FileName);
            Console.WriteLine((string)filename);
            wordDoc.SaveAs2(ref filename);
            wordDoc.Close();
            wordDoc = null;
            wordApp.Quit();
           
        }

    }
}
