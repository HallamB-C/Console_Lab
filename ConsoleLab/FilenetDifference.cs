using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleLab
{
    class FilenetDifference
    {
        public string[] GetFolders(string fileStore)
        {
            Console.WriteLine("########## Preparing to list folders ##########");

            string[] folderArray = Directory.GetDirectories(fileStore).Select(Path.GetFileName).ToArray();

            //foreach (var folder in folderArray)
            //{
            //    Console.WriteLine(folder);
            //}
            Console.WriteLine($"Number of folders: {folderArray.Length}");

            Console.WriteLine("########## Finished listing folders ##########");

            return folderArray;
        }
        public string[] GetFiles(string fileStore, string fileType)
        {
            Console.WriteLine("########## Preparing to list files ##########");

            string[] fileArray = Directory.GetFiles(fileStore, fileType).Select(Path.GetFileNameWithoutExtension).ToArray();
            if (fileArray.Length > 0)
            {

                //foreach (var file in fileArray)
                //{
                //    Console.WriteLine(file);
                //}
                Console.WriteLine("########## Finished listing files ##########");
            }
            else
            {
                Console.WriteLine("No files found matching file type");
            }

            return fileArray;
        }
        public IEnumerable<string> CompareFiles(string[] arrayOne, string[] arrayTwo)
        {
            IEnumerable<string> difference = arrayOne.Except(arrayTwo);
            using (StreamWriter sW = new StreamWriter($@"\\winprdah1781\MARSFilenetImages\fullload\difference.txt"))
            {
                foreach (var dif in difference)
                {
                    Console.WriteLine(dif);
                    sW.WriteLine(dif);
                }
            }
            return difference;
        }
    }
    // For main
    //string directory = $@"\\winprdah1781\MARSFilenetImages\fullload";
    //Program p = new Program();
    //string[] fiA = p.GetFiles(directory, @"*.zip");
    //Console.WriteLine(fiA.Length);
    //        string[] foA = p.GetFolders(directory);
    //Console.WriteLine(foA.Length);
    //        p.CompareFiles(foA, fiA);
    //        Console.ReadLine();
}
// Other for main
//FilenetDifference fN = new FilenetDifference();
//string directory = $@"\\winprdah1781\MARSFilenetImages\fullload";
//string quarantine = $@"\\winprdah1781\MARSFilenetImages\QuarantinedPolicies";
//string[] fiA = fN.GetFiles(directory, @"*.zip");
//Console.WriteLine(fiA.Length);
//            string[] foA = fN.GetFolders(directory);
//Console.WriteLine(foA.Length);
//            Console.WriteLine("Folders with no files");
//            IEnumerable<string> foldNoFile = fN.CompareFiles(foA, fiA);
//Console.WriteLine("Files with no folders");
//            IEnumerable<string> fileNoFolder = fN.CompareFiles(fiA, foA);
//            foreach (string file in fileNoFolder)
//            {
//                if (!File.Exists($@"{quarantine}\{file}.zip"))
//                {
//                    File.Move($@"{directory}\{file}.zip", $@"{quarantine}\{file}.zip");
//                }
//                else
//                {
//                    Console.WriteLine($@"File {file} is already in quarentine folder, moving and renaming.");
//                    File.Move($@"{directory}\{file}.zip", $@"{quarantine}\{file}_moved_by_dif_checker.zip");
//                }
//            }
//            Console.ReadLine();
//FilenetDifference fN = new FilenetDifference();
//string directory = $@"\\winprdah1781\MARSFilenetImages\fullload";
//string quarantine = $@"\\winprdah1781\MARSFilenetImages\Additions\October_Second_Batch";
////string[] fiA = fN.GetFiles(directory, @"*.zip");
////Console.WriteLine(fiA.Length);
//string[] foA = fN.GetFolders(quarantine);
////Console.WriteLine(foA.Length);
////Console.WriteLine("Folders with no files");
////IEnumerable<string> foldNoFile = fN.CompareFiles(foA, fiA);
////Console.WriteLine("Files with no folders");
////IEnumerable<string> fileNoFolder = fN.CompareFiles(fiA, foA);
////foreach (string file in fileNoFolder)
////{
////    if (!File.Exists($@"{quarantine}\{file}.zip"))
////    {
////        File.Move($@"{directory}\{file}.zip", $@"{quarantine}\{file}.zip");
////    }
////    else
////    {
////        Console.WriteLine($@"File {file} is already in quarentine folder, moving and renaming.");
////        File.Move($@"{directory}\{file}.zip", $@"{quarantine}\{file}_moved_by_dif_checker.zip");
////    }
////}
//DateTime oldest = new DateTime(2019, 10, 27);
//            using (StreamWriter sW = new StreamWriter($@"\\winprdah1781\MARSFilenetImages\fullload\difference.txt"))
//            {
//                foreach (string subdir in Directory.GetDirectories(directory))
//                {
//                    DirectoryInfo fil = new DirectoryInfo(subdir);
//                    if (DateTime.Compare(fil.LastWriteTime, oldest) < 0)
//                    {
//                        continue;
//                    }
//                    if (!foA.Contains(fil.Name))
//                    {
//                        sW.WriteLine(fil.Name);
//                    }
//                }
//            }