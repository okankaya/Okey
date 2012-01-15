using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Announcement
    {
        private int id;
        private String title;
        private String text;
        private DateTime date;
        private int featured;
        private String imageUrl;

        public Announcement() { }

        public Announcement(int id, String text, DateTime date)
        {
            this.id = id;
            this.text = text;
            this.date = date;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getTitle()
        {
            return title;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }

        public String getText()
        {
            return text;
        }

        public void setText(String text)
        {
            this.text = text;
        }

        public DateTime getDate()
        {
            return date;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public int getFeatured()
        {
            return featured;
        }

        public void setFeatured(int featured)
        {
            this.featured = featured;
        }

        public String getImageUrl()
        {
            return imageUrl;
        }

        public void setImageUrl(String imageUrl)
        {
            this.imageUrl = imageUrl;
        }
    }
}
