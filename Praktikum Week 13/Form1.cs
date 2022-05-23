using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_Week_13
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        static string connectionString = "server=localhost;uid=root;pwd=;database=premier_league;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        int index = 0;
        string teamnum = "";


        private void FormPlayer_Load(object sender, EventArgs e)
        {
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as 'Player ID', p.player_name as 'Name', p.birthdate as 'Birthdate', n.nation as 'Nationality', n.nationality_id as 'Nationality ID', t.team_name as 'Team', t.team_id as 'Team ID',p.team_number as 'Team Number' from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);

            TboxPlayerID.Text = player.Rows[0][0].ToString();
            TboxPlayerName.Text = player.Rows[0][1].ToString();
            DTPBIthDate.Text = player.Rows[0][2].ToString();
            NUPTeamNum.Text = player.Rows[index][7].ToString();


            DataTable nationality = new DataTable();
            sqlQuery = "select  n.nation as `Nationality`, n.nationality_id as `Nationality ID` from nationality n";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(nationality);

            CboxNationality.DataSource = nationality;
            CboxNationality.ValueMember = "Nationality ID";
            CboxNationality.DisplayMember = "Nationality";
            CboxNationality.SelectedValue = player.Rows[index][4].ToString();


            DataTable teamName = new DataTable();
            sqlQuery = "select  t.team_name as `Team`, t.team_id as `Team ID` from team t";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(teamName);

            CboxTeam.DataSource = teamName;
            CboxTeam.ValueMember = "Team ID";
            CboxTeam.DisplayMember = "Team";
            CboxTeam.SelectedValue = player.Rows[index][6].ToString();
            teamnum = CboxTeam.SelectedValue.ToString();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as 'Player ID', p.player_name as 'Name', p.birthdate as 'Birthdate', n.nation as 'Nationality', n.nationality_id as 'Nationality ID', t.team_name as 'Team', t.team_id as 'Team ID',p.team_number as 'Team Number' from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);

            TboxPlayerID.Text = player.Rows[index][0].ToString();
            TboxPlayerName.Text = player.Rows[index][1].ToString();
            DTPBIthDate.Text = player.Rows[index][2].ToString();
            NUPTeamNum.Text = player.Rows[index][7].ToString();
            CboxTeam.SelectedValue = player.Rows[index][6].ToString();
            CboxNationality.SelectedValue = player.Rows[index][4].ToString();
            teamnum = CboxNationality.SelectedValue.ToString();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (index <= 0)
            {
                index = 0;
                MessageBox.Show("Error");
            }
            else
                index --;
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as 'Player ID', p.player_name as 'Name', p.birthdate as 'Birthdate', n.nation as 'Nationality', n.nationality_id as 'Nationality ID', t.team_name as 'Team', t.team_id as 'Team ID',p.team_number as 'Team Number' from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);


            TboxPlayerID.Text = player.Rows[index][0].ToString();
            TboxPlayerName.Text = player.Rows[index][1].ToString();
            DTPBIthDate.Text = player.Rows[index][2].ToString();
            NUPTeamNum.Text = player.Rows[index][7].ToString();
            CboxTeam.SelectedValue = player.Rows[index][6].ToString();
            CboxNationality.SelectedValue = player.Rows[index][4].ToString();
            teamnum = CboxNationality.SelectedValue.ToString();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (index >= 858)
            {
                index = 858;
                MessageBox.Show("Error");
            }
            else
                index++;
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as 'Player ID', p.player_name as 'Name', p.birthdate as 'Birthdate', n.nation as 'Nationality', n.nationality_id as 'Nationality ID', t.team_name as 'Team', t.team_id as 'Team ID',p.team_number as 'Team Number' from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);


            TboxPlayerID.Text = player.Rows[index][0].ToString();
            TboxPlayerName.Text = player.Rows[index][1].ToString();
            DTPBIthDate.Text = player.Rows[index][2].ToString();
            NUPTeamNum.Text = player.Rows[index][7].ToString();
            CboxTeam.SelectedValue = player.Rows[index][6].ToString();
            CboxNationality.SelectedValue = player.Rows[index][4].ToString();
            teamnum = CboxNationality.SelectedValue.ToString();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            index = 858;
            DataTable player = new DataTable();
            sqlQuery = "select p.player_id as 'Player ID', p.player_name as 'Name', p.birthdate as 'Birthdate', n.nation as 'Nationality', n.nationality_id as 'Nationality ID', t.team_name as 'Team', t.team_id as 'Team ID',p.team_number as 'Team Number' from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);


            TboxPlayerID.Text = player.Rows[index][0].ToString();
            TboxPlayerName.Text = player.Rows[index][1].ToString();
            DTPBIthDate.Text = player.Rows[index][2].ToString();
            NUPTeamNum.Text = player.Rows[index][7].ToString();
            CboxTeam.SelectedValue = player.Rows[index][6].ToString();
            CboxNationality.SelectedValue = player.Rows[index][4].ToString();
            teamnum = CboxNationality.SelectedValue.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (LblAvaOrNot.Text == "Not Available")
            {
                MessageBox.Show("Team Number Not Available");
            }
            else
            {
                sqlQuery = "update player set team_number = '" + NUPTeamNum.Value.ToString() + "', player_name = '" + TboxPlayerName.Text + "', nationality_id = '" + CboxNationality.SelectedValue.ToString() + "', birthdate = '" + DTPBIthDate.Value.ToString("yyyMMdd") + "', team_id = '" + CboxTeam.SelectedValue.ToString() + "' where player_id = '" + TboxPlayerID.Text + "'";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Team Number" + TboxPlayerName.Text + " Telah Tersimpan.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NUPTeamNum_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable TeamNum = new DataTable();
                string teamnum2 = teamnum;
                sqlQuery = "select p.player_name as `Name`, p.team_number as `Number` from team t, player p where p.team_id = t.team_id and t.team_id = '" + teamnum2 + "' having p.team_number = " + NUPTeamNum.Value.ToString() + "";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(TeamNum);
                if (TeamNum.Rows.Count == 0)
                {
                    LblAvaOrNot.Text = "Available";
                }
                else
                {
                    LblAvaOrNot.Text = "Not Available";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
