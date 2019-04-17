using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class OvalPictureBox : PictureBox
{
    public OvalPictureBox()
    {
        this.BackColor = Color.DarkGray;
    }
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        using (var gp = new GraphicsPath())
        {
            gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            this.Region = new Region(gp);
        }
    }
      public String getStringWithUniqueCharacters(String input){

          List<Char> uniqueList = new List<Char>();    
   
         
        foreach(Char x in input)
        {
            if(!uniqueList.Contains(x)){
                uniqueList.Add(x);
            }
        }
        Char[] uniqueArray = uniqueList.ToArray();
        return new String(uniqueArray);
    }
}