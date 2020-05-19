using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        class Book
        {
            public String name;
            public String first_edition_issue;
            public String writer;
            public String publisher;
            public String publishing_house;
            public String manager;
            public String planning;
            public String editing;
            public String design;
        }

        static void Main(string[] args)
        {
            Book book = new Book();
            book.name = "PHP 프로그래밍 입문";
            book.first_edition_issue = "2013년 5월 20일";
            book.writer = "황재호";
            book.publisher = "김태헌";
            book.publishing_house = "한빛아카데미(주)";
            book.manager = "김현용";
            book.planning = "김이화";
            book.editing = "김이화";
            book.design = "여동일";
        }
    }
}
