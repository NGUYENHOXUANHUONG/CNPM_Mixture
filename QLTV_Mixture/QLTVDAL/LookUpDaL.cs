using QLTVDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTVDAL
{
    public class LookUpDAL
    {
        //singleton pattern (khởi tạo duy nhất)
        private static LookUpDAL instance;

        public static LookUpDAL Instance
        {
            get { if (instance == null) instance = new LookUpDAL(); return LookUpDAL.instance; }
            private set => instance = value;
        }

        private LookUpDAL() { }

        #region Hiện tất cả
        public List<LookUp> show()
        {
            List<LookUp> r = new List<LookUp>();

            string query = "Select * From dbo.Book";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            int dem = 1;

            foreach (DataRow row in data.Rows)
            {
                LookUp lk = new LookUp
                {
                    STT = dem,
                    BookName = row["Name"].ToString(),
                    Count = Convert.ToInt32(row["Amount"]),
                };

                //Điền thể loại sách
                query = "Select * from dbo.Bo_Cate where ID_Book = '" + row["ID"].ToString() + "'";

                DataTable BC = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rbc in BC.Rows)
                {
                    query = "Select * from dbo.Category where ID = '" + rbc.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    string tmp = dt.Rows[0].Field<string>(1);

                    lk.Cate += tmp + " ";
                }

                //Điền tên tác giả

                query = "Select * from dbo.Bo_Au where ID_Book = '" + row["ID"].ToString() + "'";

                DataTable BA = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rba in BA.Rows)
                {
                    query = "Select * from dbo.Author where ID = '" + rba.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    string tmp = dt.Rows[0].Field<string>(1);

                    lk.Author += tmp + " ";
                }

                //Tình trạng sách
                query = "Select * from dbo.CCard_Detail where ID_Book = '" + row["ID"].ToString() + "'";

                DataTable CD = DataProvider.Instance.ExecuteQuery(query);

                int sachdamuon = 0;

                foreach (DataRow rcd in CD.Rows)
                {
                    query = "Select * from dbo.Call_Card where ID = '" + rcd.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    int tmp = dt.Rows[0].Field<int>(6);

                    if (tmp == 0) sachdamuon++;

                    lk.Author += tmp + " ";
                }

                if(sachdamuon >= Convert.ToInt32(row["Amount"]))
                {
                    lk.Status = "Không thể mượn";
                }
                else
                {
                    lk.Status = "Có thể mượn";
                }

                dem++;
                r.Add(lk);
            }

            return r;
        }
        #endregion

        #region Tìm kiếm bằng tên
        public List<LookUp> SortByName(string name)
        {
            List<LookUp> result = new List<LookUp>();

            string query = "Select * From dbo.Book Where Name LIKE N'%" + name + "%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            int dem = 1;

            foreach (DataRow row in data.Rows)
            {
                LookUp lk = new LookUp
                {
                    STT = dem,
                    BookName = row["Name"].ToString(),
                    Count = Convert.ToInt32(row["Amount"]),
                };

                //Điền thể loại sách
                query = "Select * from dbo.Bo_Cate where ID_Book = '" + row["ID"].ToString() + "'";

                DataTable BC = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rbc in BC.Rows)
                {
                    query = "Select * from dbo.Category where ID = '" + rbc.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    string tmp = dt.Rows[0].Field<string>(1);

                    lk.Cate += tmp + " ";
                }

                //Điền tên tác giả

                query = "Select * from dbo.Bo_Au where ID_Book = '" + row["ID"].ToString() + "'";

                DataTable BA = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rba in BA.Rows)
                {
                    query = "Select * from dbo.Author where ID = '" + rba.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    string tmp = dt.Rows[0].Field<string>(1);

                    lk.Author += tmp + " ";
                }

                //Tình trạng sách
                query = "Select * from dbo.CCard_Detail where ID_Book = '" + row["ID"].ToString() + "'";

                DataTable CD = DataProvider.Instance.ExecuteQuery(query);

                int sachdamuon = 0;

                foreach (DataRow rcd in CD.Rows)
                {
                    query = "Select * from dbo.Call_Card where ID = '" + rcd.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    int tmp = dt.Rows[0].Field<int>(6);

                    if (tmp == 0) sachdamuon++;

                    lk.Author += tmp + " ";
                }

                if(sachdamuon >= Convert.ToInt32(row["Amount"]))
                {
                    lk.Status = "Không thể mượn";
                }
                else
                {
                    lk.Status = "Có thể mượn";
                }

                dem++;
                result.Add(lk);
            }

            return result;
        }
        #endregion

        #region Tìm kiếm bằng thể loại
        public List<LookUp> SortByCate(string IDcate)
        {
            List<LookUp> result = new List<LookUp>();
            
            //Lấy danh sách id các sách có thể loại đang tìm
            string query = "Select * from dbo.Bo_Cate where ID_Category = '" + IDcate + "'";

            DataTable BC = DataProvider.Instance.ExecuteQuery(query);

            //Lấy tên của thể loại từ id thể loại truyền vào
            query = "Select * from dbo.Category where ID = '" + IDcate + "'";

            DataTable CT = DataProvider.Instance.ExecuteQuery(query);

            string cate_name = CT.Rows[0].Field<string>(1);

            int dem = 1;

            foreach(DataRow r in BC.Rows)
            {
                //Lấy thông tin sách theo id 
                query = "Select * from dbo.Book where ID = '" + r["ID_Book"] + "'";

                DataTable BO = DataProvider.Instance.ExecuteQuery(query);

                LookUp lk = new LookUp
                {
                    STT = dem,
                    BookName = BO.Rows[0].Field<string>(1),
                    Cate = cate_name,
                    Count = BO.Rows[0].Field<int>(2),
                };

                //Điền tên tác giả

                query = "Select * from dbo.Bo_Au where ID_Book = '" + r["ID_Book"] + "'";

                DataTable BA = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rba in BA.Rows)
                {
                    query = "Select * from dbo.Author where ID = '" + rba.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    string tmp = dt.Rows[0].Field<string>(1);

                    lk.Author += tmp + " ";
                }

                //Tình trạng sách
                query = "Select * from dbo.CCard_Detail where ID_Book = '" + r["ID_Book"] + "'";

                DataTable CD = DataProvider.Instance.ExecuteQuery(query);

                int sachdamuon = 0;

                foreach (DataRow rcd in CD.Rows)
                {
                    query = "Select * from dbo.Call_Card where ID = '" + rcd.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    int tmp = dt.Rows[0].Field<int>(6);

                    if (tmp == 0) sachdamuon++;

                    lk.Author += tmp + " ";
                }

                if (sachdamuon >= BO.Rows[0].Field<int>(2))
                {
                    lk.Status = "Không thể mượn";
                }
                else
                {
                    lk.Status = "Có thể mượn";
                }

                dem++;
                result.Add(lk);
            }

            return result;
        }
        #endregion

        #region Tìm kiếm bằng tác giả
        public List<LookUp> SortByAuthor(string IDAuthor)
        {
            List<LookUp> result = new List<LookUp>();

            //Lấy danh sách id các sách có tác giả đang tìm
            string query = "Select * from dbo.Bo_Au where ID_Author = '" + IDAuthor + "'";

            DataTable BA = DataProvider.Instance.ExecuteQuery(query);

            //Lấy tên của thể loại từ id thể loại truyền vào
            query = "Select * from dbo.Author where ID = '" + IDAuthor + "'";

            DataTable AU = DataProvider.Instance.ExecuteQuery(query);

            string au_name = AU.Rows[0].Field<string>(1);

            int dem = 1;

            foreach(DataRow r in BA.Rows)
            {
                //Lấy thông tin sách theo id 
                query = "Select * from dbo.Book where ID = '" + r["ID_Book"] + "'";

                DataTable BO = DataProvider.Instance.ExecuteQuery(query);

                LookUp lk = new LookUp
                {
                    STT = dem,
                    BookName = BO.Rows[0].Field<string>(1),
                    Author = au_name,
                    Count = BO.Rows[0].Field<int>(2),
                };

                //Điền thể loại sách
                query = "Select * from dbo.Bo_Cate where ID_Book = '" + r["ID_Book"] + "'";

                DataTable BC = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rbc in BC.Rows)
                {
                    query = "Select * from dbo.Category where ID = '" + rbc.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    string tmp = dt.Rows[0].Field<string>(1);

                    lk.Cate += tmp + " ";
                }

                //Tình trạng sách
                query = "Select * from dbo.CCard_Detail where ID_Book = '" + r["ID_Book"] + "'";

                DataTable CD = DataProvider.Instance.ExecuteQuery(query);

                int sachdamuon = 0;

                foreach (DataRow rcd in CD.Rows)
                {
                    query = "Select * from dbo.Call_Card where ID = '" + rcd.Field<string>(1) + "'";

                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                    int tmp = dt.Rows[0].Field<int>(6);

                    if (tmp == 0) sachdamuon++;

                    lk.Author += tmp + " ";
                }

                if (sachdamuon >= BO.Rows[0].Field<int>(2))
                {
                    lk.Status = "Không thể mượn";
                }
                else
                {
                    lk.Status = "Có thể mượn";
                }

                dem++;
                result.Add(lk);
            }

            return result;
        }
        #endregion

        #region Tìm kiếm bằng tên sách và thể loại
        public List<LookUp> SortByBookAndCate(string bookname, string IDCate)
        {
            List<LookUp> result = new List<LookUp>();

            string query = "Select * From dbo.Book Where Name LIKE N'%" + bookname + "%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            //Lấy tên của thể loại từ id thể loại truyền vào
            query = "Select * from dbo.Category where ID = '" + IDCate + "'";

            DataTable CT = DataProvider.Instance.ExecuteQuery(query);

            string cate_name = CT.Rows[0].Field<string>(1);

            int dem = 1;

            foreach (DataRow row in data.Rows)
            {
                query = "Select * from dbo.Bo_Cate where ID_Book = '" + row["ID"].ToString() + "' and ID_Category = '" + IDCate + "'";
                DataTable BC = DataProvider.Instance.ExecuteQuery(query);

                if (BC.Rows.Count > 0)
                {
                    LookUp lk = new LookUp
                    {
                        STT = dem,
                        BookName = row["Name"].ToString(),
                        Cate = cate_name,
                        Count = Convert.ToInt32(row["Amount"].ToString()),
                    };

                    //Điền tên tác giả
                    query = "Select * from dbo.Bo_Au where ID_Book = '" + row["ID"] + "'";

                    DataTable BA = DataProvider.Instance.ExecuteQuery(query);

                    foreach (DataRow rba in BA.Rows)
                    {
                        query = "Select * from dbo.Author where ID = '" + rba.Field<string>(1) + "'";

                        DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                        string tmp = dt.Rows[0].Field<string>(1);

                        lk.Author += tmp + " ";
                    }

                    //Tình trạng sách
                    query = "Select * from dbo.CCard_Detail where ID_Book = '" + row["ID"] + "'";

                    DataTable CD = DataProvider.Instance.ExecuteQuery(query);

                    int sachdamuon = 0;

                    foreach (DataRow rcd in CD.Rows)
                    {
                        query = "Select * from dbo.Call_Card where ID = '" + rcd.Field<string>(1) + "'";

                        DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                        int tmp = dt.Rows[0].Field<int>(6);

                        if (tmp == 0) sachdamuon++;

                        lk.Author += tmp + " ";
                    }

                    if (sachdamuon >= Convert.ToInt32(row["Amount"]))
                    {
                        lk.Status = "Không thể mượn";
                    }
                    else
                    {
                        lk.Status = "Có thể mượn";
                    }

                    dem++;
                    result.Add(lk);
                }
            }

            return result;
        }
        #endregion

        #region Tìm kiếm bằng tên sách và tác giả
        public List<LookUp> SortByBookAndAuth(string bookname, string IDAuthor)
        {
            List<LookUp> result = new List<LookUp>();

            string query = "Select * From dbo.Book Where Name LIKE N'%" + bookname + "%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            //Lấy tên của tác giả từ id thể loại truyền vào
            query = "Select * from dbo.Author where ID = '" + IDAuthor + "'";

            DataTable CA = DataProvider.Instance.ExecuteQuery(query);

            string au_name = CA.Rows[0].Field<string>(1);

            int dem = 1;

            foreach (DataRow row in data.Rows)
            {
                query = "Select * from dbo.Bo_Au where ID_Book = '" + row["ID"].ToString() + "' and ID_Author = '" + IDAuthor + "'";
                DataTable BA = DataProvider.Instance.ExecuteQuery(query);

                if (BA.Rows.Count > 0)
                {
                    LookUp lk = new LookUp
                    {
                        STT = dem,
                        BookName = row["Name"].ToString(),
                        Author = au_name,
                        Count = Convert.ToInt32(row["Amount"].ToString()),
                    };

                    //Điền thể loại sách
                    query = "Select * from dbo.Bo_Cate where ID_Book = '" + row["ID"] + "'";

                    DataTable BC = DataProvider.Instance.ExecuteQuery(query);

                    foreach (DataRow rbc in BC.Rows)
                    {
                        query = "Select * from dbo.Category where ID = '" + rbc.Field<string>(1) + "'";

                        DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                        string tmp = dt.Rows[0].Field<string>(1);

                        lk.Cate += tmp + " ";
                    }

                    //Tình trạng sách
                    query = "Select * from dbo.CCard_Detail where ID_Book = '" + row["ID"] + "'";

                    DataTable CD = DataProvider.Instance.ExecuteQuery(query);

                    int sachdamuon = 0;

                    foreach (DataRow rcd in CD.Rows)
                    {
                        query = "Select * from dbo.Call_Card where ID = '" + rcd.Field<string>(1) + "'";

                        DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                        int tmp = dt.Rows[0].Field<int>(6);

                        if (tmp == 0) sachdamuon++;

                        lk.Author += tmp + " ";
                    }

                    if (sachdamuon >= Convert.ToInt32(row["Amount"]))
                    {
                        lk.Status = "Không thể mượn";
                    }
                    else
                    {
                        lk.Status = "Có thể mượn";
                    }

                    dem++;
                    result.Add(lk);
                }
            }

            return result;
        }
        #endregion

        #region Tìm kiếm bằng thể loại và tác giả
        public List<LookUp> SortByCateAndAuth(string IDCate, string IDAuthor)
        {
            List<LookUp> result = new List<LookUp>();

            //Lấy danh sách id các sách có thể loại đang tìm
            string query = "Select * from dbo.Bo_Cate where ID_Category = '" + IDCate + "'";

            DataTable BC = DataProvider.Instance.ExecuteQuery(query);

            //Lấy tên của thể loại từ id thể loại truyền vào
            query = "Select * from dbo.Category where ID = '" + IDCate + "'";

            DataTable CT = DataProvider.Instance.ExecuteQuery(query);

            string cate_name = CT.Rows[0].Field<string>(1);

            //Lấy tên của tác giả từ id thể loại truyền vào
            query = "Select * from dbo.Author where ID = '" + IDAuthor + "'";

            DataTable CA = DataProvider.Instance.ExecuteQuery(query);

            string au_name = CA.Rows[0].Field<string>(1);

            int dem = 1;

            foreach (DataRow r in BC.Rows)
            {
                //Lấy thông tin sách theo id 
                query = "Select * from dbo.Book where ID = '" + r["ID_Book"] + "'";

                DataTable BO = DataProvider.Instance.ExecuteQuery(query);

                foreach(DataRow row in BO.Rows)
                {
                    query = "Select * from dbo.Bo_Au where ID_Author = '" + IDAuthor + "' and ID_Book = '" + row["ID"].ToString() + "'";

                    DataTable BA = DataProvider.Instance.ExecuteQuery(query);

                    if (BA.Rows.Count > 0)
                    {
                        LookUp lk = new LookUp
                        {
                            STT = dem,
                            BookName = row["Name"].ToString(),
                            Cate = cate_name,
                            Author = au_name,
                            Count = Convert.ToInt32(row["Amount"])
                        };
                        //Tình trạng sách
                        query = "Select * from dbo.CCard_Detail where ID_Book = '" + row["ID"] + "'";

                        DataTable CD = DataProvider.Instance.ExecuteQuery(query);

                        int sachdamuon = 0;

                        foreach (DataRow rcd in CD.Rows)
                        {
                            query = "Select * from dbo.Call_Card where ID = '" + rcd.Field<string>(1) + "'";

                            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                            int tmp = dt.Rows[0].Field<int>(6);

                            if (tmp == 0) sachdamuon++;

                            lk.Author += tmp + " ";
                        }

                        if (sachdamuon >= Convert.ToInt32(row["Amount"]))
                        {
                            lk.Status = "Không thể mượn";
                        }
                        else
                        {
                            lk.Status = "Có thể mượn";
                        }

                        dem++;
                        result.Add(lk);
                    }
                }
            }

            return result;
        }
        #endregion

        #region Tìm kiếm bằng cả 3 thông tin
        public List<LookUp> SortBy3Ele(string bookname, string IDCate, string IDAuthor)
        {
            List<LookUp> result = new List<LookUp>();

            string query = "Select * From dbo.Book Where Name LIKE N'%" + bookname + "%'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            //Lấy tên của thể loại từ id thể loại truyền vào
            query = "Select * from dbo.Category where ID = '" + IDCate + "'";

            DataTable CT = DataProvider.Instance.ExecuteQuery(query);

            string cate_name = CT.Rows[0].Field<string>(1);

            //Lấy tên của tác giả từ id thể loại truyền vào
            query = "Select * from dbo.Author where ID = '" + IDAuthor + "'";

            DataTable CA = DataProvider.Instance.ExecuteQuery(query);

            string au_name = CA.Rows[0].Field<string>(1);

            int dem = 1;

            foreach(DataRow row in data.Rows)
            {
                query = "Select * from dbo.Bo_Au where ID_Book = '" + row["ID"].ToString() + "' and ID_Author = '" + IDAuthor + "'";
                DataTable BA = DataProvider.Instance.ExecuteQuery(query);

                if (BA.Rows.Count > 0)
                {
                    query = "Select * from dbo.Bo_Cate where ID_Book = '" + row["ID"].ToString() + "' and ID_Category = '" + IDCate + "'";
                    DataTable BC = DataProvider.Instance.ExecuteQuery(query);

                    if (BC.Rows.Count > 0)
                    {
                        LookUp lk = new LookUp
                        {
                            STT = dem,
                            BookName = row["Name"].ToString(),
                            Cate = cate_name,
                            Author = au_name,
                            Count = Convert.ToInt32(row["Amount"].ToString()),
                        };

                        //Tình trạng sách
                        query = "Select * from dbo.CCard_Detail where ID_Book = '" + row["ID"] + "'";

                        DataTable CD = DataProvider.Instance.ExecuteQuery(query);

                        int sachdamuon = 0;

                        foreach (DataRow rcd in CD.Rows)
                        {
                            query = "Select * from dbo.Call_Card where ID = '" + rcd.Field<string>(1) + "'";

                            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

                            int tmp = dt.Rows[0].Field<int>(6);

                            if (tmp == 0) sachdamuon++;

                            lk.Author += tmp + " ";
                        }

                        if (sachdamuon >= Convert.ToInt32(row["Amount"]))
                        {
                            lk.Status = "Không thể mượn";
                        }
                        else
                        {
                            lk.Status = "Có thể mượn";
                        }

                        dem++;
                        result.Add(lk);
                    }
                }
            }

            return result;
        }
        #endregion
    }
}
