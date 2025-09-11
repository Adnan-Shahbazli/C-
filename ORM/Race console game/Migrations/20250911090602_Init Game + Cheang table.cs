using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Race_console_game.Migrations
{
    /// <inheritdoc />
    public partial class InitGameCheangtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DriversCharacteristics",
                table: "DriversCharacteristics");

            migrationBuilder.RenameTable(
                name: "DriversCharacteristics",
                newName: "DriverCharacteristics");

            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "Drivers",
                type: "char(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Drivers",
                type: "varchar(80)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Drivers",
                type: "varchar(80)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SpeedRating",
                table: "DriverCharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 10,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "DriverCharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 10,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QualifyingRating",
                table: "DriverCharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 10,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "DriverCharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OvertakingRating",
                table: "DriverCharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 10,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Level",
                table: "DriverCharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Ex",
                table: "DriverCharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DefenseRating",
                table: "DriverCharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 10,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ConcentrationRating",
                table: "DriverCharacteristics",
                type: "int",
                nullable: false,
                defaultValue: 10,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DriverCharacteristics",
                table: "DriverCharacteristics",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_FirstDefaultDriverId",
                table: "Teams",
                column: "FirstDefaultDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_FirstNowDriverId",
                table: "Teams",
                column: "FirstNowDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SeconDefaultdDriverId",
                table: "Teams",
                column: "SeconDefaultdDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SeconNowdDriverId",
                table: "Teams",
                column: "SeconNowdDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_GameSaves_SeasonId",
                table: "GameSaves",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_GameSaves_TeamId",
                table: "GameSaves",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_CharacteristicsId",
                table: "Drivers",
                column: "CharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_GameSaveId",
                table: "Drivers",
                column: "GameSaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_SeasonId",
                table: "Calendars",
                column: "SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_Seasons_SeasonId",
                table: "Calendars",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_DriverCharacteristics_CharacteristicsId",
                table: "Drivers",
                column: "CharacteristicsId",
                principalTable: "DriverCharacteristics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_GameSaves_GameSaveId",
                table: "Drivers",
                column: "GameSaveId",
                principalTable: "GameSaves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GameSaves_Seasons_SeasonId",
                table: "GameSaves",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GameSaves_Teams_TeamId",
                table: "GameSaves",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Drivers_FirstDefaultDriverId",
                table: "Teams",
                column: "FirstDefaultDriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Drivers_FirstNowDriverId",
                table: "Teams",
                column: "FirstNowDriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Drivers_SeconDefaultdDriverId",
                table: "Teams",
                column: "SeconDefaultdDriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Drivers_SeconNowdDriverId",
                table: "Teams",
                column: "SeconNowdDriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Seasons_SeasonId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_DriverCharacteristics_CharacteristicsId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_GameSaves_GameSaveId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_GameSaves_Seasons_SeasonId",
                table: "GameSaves");

            migrationBuilder.DropForeignKey(
                name: "FK_GameSaves_Teams_TeamId",
                table: "GameSaves");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Drivers_FirstDefaultDriverId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Drivers_FirstNowDriverId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Drivers_SeconDefaultdDriverId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Drivers_SeconNowdDriverId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_FirstDefaultDriverId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_FirstNowDriverId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SeconDefaultdDriverId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SeconNowdDriverId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_GameSaves_SeasonId",
                table: "GameSaves");

            migrationBuilder.DropIndex(
                name: "IX_GameSaves_TeamId",
                table: "GameSaves");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_CharacteristicsId",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_GameSaveId",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_SeasonId",
                table: "Calendars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DriverCharacteristics",
                table: "DriverCharacteristics");

            migrationBuilder.RenameTable(
                name: "DriverCharacteristics",
                newName: "DriversCharacteristics");

            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(3)");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Drivers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)");

            migrationBuilder.AlterColumn<int>(
                name: "SpeedRating",
                table: "DriversCharacteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "DriversCharacteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "QualifyingRating",
                table: "DriversCharacteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "DriversCharacteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "OvertakingRating",
                table: "DriversCharacteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Level",
                table: "DriversCharacteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Ex",
                table: "DriversCharacteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "DefenseRating",
                table: "DriversCharacteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "ConcentrationRating",
                table: "DriversCharacteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DriversCharacteristics",
                table: "DriversCharacteristics",
                column: "Id");
        }
    }
}
