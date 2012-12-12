/* User: Erin
 * Date: 12/12/2012
 * Time: 6:27 AM
 */
using System;
using System.IO;

public class KsJoiner {
	public static void JoinFile(string inputFile, string outputFile) {
		FileInfo fInfo=new FileInfo(inputFile);
		long iLen=fInfo.Length;
		FileStream ifs=new FileStream(inputFile, FileMode.Open);
		BinaryReader reader=new BinaryReader(ifs);
		
		FileInfo fi=new FileInfo(outputFile);
		FileMode fm=FileMode.Append;
		if(!fi.Exists) fm=FileMode.CreateNew;
		FileStream ofs=new FileStream(outputFile, fm);
		BinaryWriter writer=new BinaryWriter(ofs);
		
		for(long i=0; i<iLen; i++)
			writer.Write(reader.ReadByte());

		ifs.Close(); reader.Close();
		ofs.Close(); writer.Close();
	}
}

