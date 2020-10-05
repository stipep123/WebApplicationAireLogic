using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppAireLogic.Migrations
{
    public partial class AddDummyValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Bob Dylan" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Jimmy Hendrix" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Ed Sheeran" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "John Legend" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Michael Jackson" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Lady Gaga" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Name", "Year", "ArtistId" },
                values: new object[] { 1, "Bob Dylan album 1", 2008, 1 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Name", "Year", "ArtistId" },
                values: new object[] { 2, "Bob Dylan album 2", 2010, 1 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Name", "Year", "ArtistId" },
                values: new object[] { 3, "Jimmy Hendrix album 1", 2008, 2 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Name", "Year", "ArtistId" },
                values: new object[] { 4, "Ed Sheeran album 1", 2019, 3 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Name", "Year", "ArtistId" },
                values: new object[] { 5, "John Legend album 1", 2012, 4 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Name", "Year", "ArtistId" },
                values: new object[] { 6, "Michael Jackson album 1", 1996, 5 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Name", "Year", "ArtistId" },
                values: new object[] { 7, "Lady Gaga album 1", 2018, 6 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Name", "Lyrics", "AlbumId" },
                values: new object[] { 1, "Knocking on the Heavens door" ,"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Name", "Lyrics", "AlbumId" },
                values: new object[] { 2, "Just like a woman", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum three more words.", 2 });

            migrationBuilder.InsertData(
               table: "Songs",
               columns: new[] { "Id", "Name", "Lyrics", "AlbumId" },
               values: new object[] { 3, "Hurricane", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 2 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Name", "Lyrics", "AlbumId" },
                values: new object[] { 4, "Foxy lady", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum three more words.", 3 });

            migrationBuilder.InsertData(
               table: "Songs",
               columns: new[] { "Id", "Name", "Lyrics", "AlbumId" },
               values: new object[] { 5, "Perfect", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 4 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Name", "Lyrics", "AlbumId" },
                values: new object[] { 6, "All of me", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum three more words.", 5 });

            migrationBuilder.InsertData(
               table: "Songs",
               columns: new[] { "Id", "Name", "Lyrics", "AlbumId" },
               values: new object[] { 7, "Billie Jean", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 6 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Name", "Lyrics", "AlbumId" },
                values: new object[] { 8, "Poker face", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum three more words.", 7 });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
