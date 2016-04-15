using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class Quiz
    {
        OleDbConnection cm = new OleDbConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

        public getData getQuestionTypes()
        {
            getData gd = new getData();
            OleDbCommand cmd = new OleDbCommand("SELECT ID, QuestionType FROM QuestionTypes ORDER BY ID", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gd.Count = ds.Tables[0].Rows.Count;
            gd.DS = ds;
            gd.DT = ds.Tables[0];
            return gd;
        }

        public getData addQuestion(Questions q)
        {
            getData gd = new getData();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Questions(QuestionType, Question, Option1, Option2, Option3, Option4, Answer, MaxTime, Points) VALUES (@QTP, @QTN, @OP1, @OP2, @OP3, @OP4, @ANS, @MAX, @PTS)", cm);
            cmd.Parameters.AddWithValue("@QTP", q.QuestionType);
            cmd.Parameters.AddWithValue("@QTN", q.Question);
            cmd.Parameters.AddWithValue("@OP1", q.Option1);
            cmd.Parameters.AddWithValue("@OP2", q.Option2);
            cmd.Parameters.AddWithValue("@OP3", q.Option3);
            cmd.Parameters.AddWithValue("@OP4", q.Option4);
            cmd.Parameters.AddWithValue("@ANS", q.Answer);
            cmd.Parameters.AddWithValue("@MAX", q.MaxTime);
            cmd.Parameters.AddWithValue("@PTS", q.Points);
            try
            {
                cm.Open();
                gd.Count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                gd.Message = ex.Message;
            }
            finally { cm.Close(); }
            return gd;
        }

        public getData updateQuestion(Questions q)
        {
            getData gd = new getData();
            OleDbCommand cmd = new OleDbCommand("UPDATE Questions SET QuestionType=@QTP, Question=@QTN, Option1=@OP1, Option2=@OP2, Option3=@OP3, Option4=@OP4, Answer=@ANS, MaxTime=@MAX, Points=@PTS WHERE ID=" + q.ID, cm);
            cmd.Parameters.AddWithValue("@QTP", q.QuestionType);
            cmd.Parameters.AddWithValue("@QTN", q.Question);
            cmd.Parameters.AddWithValue("@OP1", q.Option1);
            cmd.Parameters.AddWithValue("@OP2", q.Option2);
            cmd.Parameters.AddWithValue("@OP3", q.Option3);
            cmd.Parameters.AddWithValue("@OP4", q.Option4);
            cmd.Parameters.AddWithValue("@ANS", q.Answer);
            cmd.Parameters.AddWithValue("@MAX", q.MaxTime);
            cmd.Parameters.AddWithValue("@PTS", q.Points);
            try
            {
                cm.Open();
                gd.Count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                gd.Message = ex.Message;
            }
            finally { cm.Close(); }
            return gd;
        }

        public getData deleteQuestion(int QID)
        {
            getData gd = new getData();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM Questions WHERE ID=" + QID, cm);
            try
            {
                cm.Open();
                gd.Count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                gd.Message = ex.Message;
            }
            finally { cm.Close(); }
            return gd;
        }

        public Questions getQuestion(int QuestionType)
        {
            Questions q = new Questions();
            OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 * FROM Questions WHERE Asked=False AND QuestionType=" + QuestionType + " ORDER BY rnd(ID)", cm);
            try
            {
                cm.Open();
                OleDbDataReader rd = cmd.ExecuteReader();
                rd.Read();
                q.ID = Convert.ToInt32(rd[0]);
                q.QuestionType = Convert.ToInt32(rd[1]);
                q.Question = rd[2].ToString();
                q.Option1 = rd[3].ToString();
                q.Option2 = rd[4].ToString();
                q.Option3 = rd[5].ToString();
                q.Option4 = rd[6].ToString();
                q.Answer = rd[7].ToString();
                q.MaxTime = Convert.ToInt32(rd[8]);
                q.Points = Convert.ToInt32(rd[9]);
            }
            catch
            {
                q.ID = 0;
                q.QuestionType = 0;
                q.Question = null;
                q.Option1 = null;
                q.Option2 = null;
                q.Option3 = null;
                q.Option4 = null;
                q.Answer = null;
                q.MaxTime = 0;
                q.Points = 0;
            }
            finally { cm.Close(); }
            return q;
        }

        public getData getQuestions()
        {
            getData gd = new getData();
            OleDbCommand cmd = new OleDbCommand("SELECT q.ID, qt.ID AS QID, qt.QuestionType, q.Question, q.Option1, q.Option2, q.Option3, q.Option4, q.Answer, q.MaxTime, q.Points FROM QuestionTypes qt INNER JOIN Questions q ON qt.ID = q.QuestionType", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            gd.Count = dt.Rows.Count;
            gd.DS = ds;
            gd.DT = dt;
            return gd;
        }

        public getData getQuestions(int QID)
        {
            getData gd = new getData();
            OleDbCommand cmd = new OleDbCommand("SELECT q.ID, qt.ID AS QID, qt.QuestionType, q.Question, q.Option1, q.Option2, q.Option3, q.Option4, q.Answer, q.MaxTime, q.Points FROM QuestionTypes qt INNER JOIN Questions q ON qt.ID = q.QuestionType WHERE q.ID = " + QID, cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            gd.Count = dt.Rows.Count;
            gd.DS = ds;
            gd.DT = dt;
            return gd;
        }

        public void setQuestionAsAnswered(int QuestionID)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE Questions SET Asked=True WHERE ID=" + QuestionID, cm);
            try
            {
                cm.Open();
                cmd.ExecuteNonQuery();
            }
            catch {;
            }
            finally { cm.Close(); }
        }

        public getData getAllTeams()
        {
            getData gd = new getData();
            OleDbCommand cmd = new OleDbCommand("SELECT ID, TeamName, Status FROM Teams", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            gd.Count = dt.Rows.Count;
            gd.DS = ds;
            gd.DT = dt;
            return gd;
        }

        public getData getTeams(string Status)
        {
            getData gd = new getData();
            OleDbCommand cmd = new OleDbCommand("SELECT ID, TeamName, Status FROM Teams WHERE Status='" + Status + "'", cm);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            gd.Count = dt.Rows.Count;
            gd.DS = ds;
            gd.DT = dt;
            return gd;
        }

        public void playAudio(string url)
        {
            WMPLib.WindowsMediaPlayer MPlayer = new WMPLib.WindowsMediaPlayer();
            MPlayer.settings.volume = 100;
            MPlayer.URL = url;
            MPlayer.controls.play();
        }
    }

    class getData
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public DataSet DS { get; set; }
        public DataTable  DT { get; set; }

    }

    class QuestionTypes
    {
        public int ID { get; set; }
        public string QuestionType { get; set; }

    }

    class Questions
    {
        public int ID { get; set; }
        public int QuestionType { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Answer { get; set; }
        public int MaxTime { get; set; }
        public int Points { get; set; }

    }

    class Answers
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public string Answer { get; set; }
        public bool Correct { get; set; }

    }

    class Teams
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public string Address { get; set; }

    }
}
