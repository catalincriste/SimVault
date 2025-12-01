

using System.IO;
using SharpSevenZip;
namespace SimVault.Classes
{
    public class FileDirectoryService
    {
        private string SourcePath { get; set; } 

        public FileDirectoryService(string path)
        {
            SourcePath = path;
        }


        public List<TreeNode> GetAllFilesAndDirectoriesAsTreeView()
        {


         //   SharpSevenZipExtractor ex = new("C:\\Users\\Catalin\\Documents\\EA Games\\The Sims™ 2 Ultimate Collection_20251128_UpdatedMoreDefaults.7z");

           // ex.ExtractArchive("C:\\Users\\Catalin\\Desktop\\Example\\output");
            

            //ex.Extracting()
            List<string> directories = new List<string>();

            var rootDir = new DirectoryInfo(SourcePath);


            List<TreeNode> nodes = new List<TreeNode>();


            foreach (var item in rootDir.GetDirectories())
            {
                nodes.Add(Test(item));
            }
            return nodes;
        }

        private TreeNode Test(DirectoryInfo dirInfoRoot)
        {
            try
            {
                TreeNode node = new TreeNode();
                node.ImageIndex = 0;
                node.Text = dirInfoRoot.Name;

                foreach (var dir in dirInfoRoot.GetDirectories())
                {

                    node.Nodes.Add(new TreeNode()
                    {
                        Text = dir.Name,
                        ImageIndex = 0,
                        SelectedImageIndex = 0,
                    });

                    Test(dir);
                }

                foreach(var file in dirInfoRoot.GetFiles())
                {
                    node.Nodes.Add(new TreeNode()
                    {
                        Text = file.Name,
                        ImageIndex = 1,
                        SelectedImageIndex = 1
                    });
                }

                return node;
            }
            catch(Exception e)
            {
                MessageBox.Show("Cenas erro");

                return null;
            }
        }
      /*  public void DirSearch_ex3(string sDir)
        {
            //Console.WriteLine("DirSearch..(" + sDir + ")");
            try
            {
                Console.WriteLine(sDir);

                foreach (string f in Directory.GetFiles(sDir))
                {
                    Console.WriteLine(f);
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearch_ex3(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }*/
    }
}
