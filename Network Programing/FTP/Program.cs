using FluentFTP;

using FtpClient client = new FtpClient("ftp://ftp.uni-kl.de");

//ftp://ftp.uni-kl.de/pub/linux/gentoo/distfiles/4b/oneko-1.2-dog.png

client.Connect();

// client.DownloadFile(
//     localPath: "dog.png",
//     remotePath: "/pub/linux/gentoo/distfiles/4b/oneko-1.2-dog.png"
// );

var clientnamelisting = client.GetNameListing("/pub/linux/gentoo/distfiles/4b/");

// foreach (var item in clientnamelisting)
// {
//     //System.Console.WriteLine(item);
// }

client.DownloadFiles(localDir: "./Files", remotePaths: clientnamelisting);