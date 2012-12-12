/* User: Erin
 * Date: 12/12/2012
 * Time: 6:27 AM
 */
using System;
using System.IO;

public class KsSplitter {
	public enum chunkSizeType { bytes, kb, mb, gb }

	public static void SplitFile(string inputFile, string outputDir, long chunkSizeInBytes) {
		FileInfo fi=new FileInfo(inputFile);
		SplitFile(inputFile, outputDir, fi.Name, chunkSizeInBytes);
	}
	public static void SplitFile(string inputFile, string outputDir, string outputPrefix, long chunkSize, chunkSizeType chunkSizeTyp) {
		SplitFile(inputFile, outputDir, outputPrefix, GetSizeInBytes(chunkSize, chunkSizeTyp));
	}
	public static void SplitFile(string inputFile, string outputDir, long chunkSize, chunkSizeType chunkSizeTyp) {
		FileInfo fi=new FileInfo(inputFile);
		SplitFile(inputFile, outputDir, fi.Name, GetSizeInBytes(chunkSize, chunkSizeTyp));
	}
	public static void SplitFile(string inputFile, string outputDir, string outputPrefix, long chunkSizeInBytes) {
		if(!outputDir.EndsWith("\\")) outputDir+="\\";
		FileInfo fInfo=new FileInfo(inputFile);
		long iLen=fInfo.Length, pos=0, len, cnt=0;
		FileStream ifs=new FileStream(inputFile, FileMode.Open, FileAccess.Read);
		BinaryReader reader=new BinaryReader(ifs);
		while (pos<iLen) {
			cnt++;
			FileStream ofs=new FileStream(outputDir+outputPrefix+".ksChunk"+cnt.ToString().PadLeft(3, '0'), FileMode.Create);
			BinaryWriter writer=new BinaryWriter(ofs);
			len=chunkSizeInBytes;
			if(pos<1) len-=200;
			if((pos+len)>iLen) len=(iLen-pos);
			
			for(long i=0, l=len; i<l; i++) {
				writer.Write(reader.ReadByte());
				pos++;
			};
			writer.Close();
			ofs.Close();
			
		}
	
		reader.Close();
		ifs.Close();
		
	}

	public static long GetSizeInBytes(long val, string sizeType) {
		switch(sizeType) {
			case "kb": val*=1000; break;
			case "mb": val*=1000000; break;
			case "gb": val*=1000000000; break;
		}
		return val;
	}
	public static long GetSizeInBytes(long val, chunkSizeType sizeType) {
		string str="bytes";
		switch(sizeType) {
			case chunkSizeType.kb: str="kb"; break;
			case chunkSizeType.mb: str="mb"; break;
			case chunkSizeType.gb: str="gb"; break;
		}
		return GetSizeInBytes(val, str);
	}
	
}
