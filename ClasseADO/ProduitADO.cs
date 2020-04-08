using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClasseADO
{
    public class ProduitADO
    {
        public void Inserer(Produit P)
        {
            String req = "insert into Produit (Ref_Prod ,Desig_Prod, Categ_Prod, PrixV_Prod, Qte_Stk_Prod) VALUES (@Ref_Prod ,@Desig_Prod, @Categ_Prod, @PrixV_Prod, @ Qte_Stk_Prod)";
            SqlCommand cmd = new SqlCommand(req, Connexion.cn);
            cmd.Parameters.AddWithValue("@Ref_Prod",P.ref_prod);
            cmd.Parameters.AddWithValue("@Desig_Prod", P.desig_prod);
            cmd.Parameters.AddWithValue("@Categ_Prod", P.categ_prod);
            cmd.Parameters.AddWithValue("@PrixV_Prod", P.prixv_prod);
            cmd.Parameters.AddWithValue("@Qte_Stk_Prod", P.qte_stk_prod);
            cmd.ExecuteNonQuery();
        }

        public static bool Existe_Produit(String refP)
        {
            string req = "select * From Produit where Ref_Prod = @ref";
            SqlCommand cmd = new SqlCommand(req, Connexion.cn);
            cmd.Parameters.AddWithValue("@ref", refP);
            SqlDataReader drCmd = cmd.ExecuteReader();
            if(!drCmd.HasRows)
            {
                drCmd.Close();
                return false;
            }
            drCmd.Close();
            return true;
        }

        public void Supprimer(String refP)
        {
            string req = "delete from Produit where Ref_Prod = @ref";
            SqlCommand cmd = new SqlCommand(req, Connexion.cn);
            cmd.Parameters.AddWithValue("@ref", refP);
            cmd.ExecuteNonQuery();
        }

        public void Modifier(Produit P)
        {
            String req = "update Produit set Desig_Prod = @Desig_Prod, Categ_Prod = @Categ_Prod, PrixV_Prod = @PrixV_Prod, Qte_Stk_Prod = @ Qte_Stk_Prod where Ref_Prod = @Ref_Prod";
            SqlCommand cmd = new SqlCommand(req, Connexion.cn);
            cmd.Parameters.AddWithValue("@Ref_Prod", P.ref_prod);
            cmd.Parameters.AddWithValue("@Desig_Prod", P.desig_prod);
            cmd.Parameters.AddWithValue("@Categ_Prod", P.categ_prod);
            cmd.Parameters.AddWithValue("@PrixV_Prod", P.prixv_prod);
            cmd.Parameters.AddWithValue("@Qte_Stk_Prod", P.qte_stk_prod);
            cmd.ExecuteNonQuery();
        }

        public static DataTable Liste_Produit()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit", Connexion.cn) ;
            da.Fill(dt);
            return dt;
        }

        public static DataTable Liste_Prod_ParCateg(string categ)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Categ_Prod = @Categ_Prod", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Categ_Prod", categ);
            da.Fill(dt);
            return dt;
        }

        public static DataTable Liste_Prod_ParRef(string refP)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Ref_Prod = @Ref_Prod", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Ref_Prod", refP);
            da.Fill(dt);
            return dt;
        }

        public static DataTable Liste_Prod_ParDesig(string desig)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Desig_Prod = @Desig_Prod", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Desig_Prod", desig+"%");
            da.Fill(dt);
            return dt;
        }
    }
}
