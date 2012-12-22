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
		SplitFile(inputFile, outputDir, fi.Name, chunkSizeInBytes, new KsSplitJoinHandler());
	}
	public static void SplitFile(string inputFile, string outputDir, string outputPrefix, long chunkSize, chunkSizeType chunkSizeTyp) {
		SplitFile(inputFile, outputDir, outputPrefix, GetSizeInBytes(chunkSize, chunkSizeTyp), new KsSplitJoinHandler());
	}
	public static void SplitFile(string inputFile, string outputDir, long chunkSize, chunkSizeType chunkSizeTyp) {
		FileInfo fi=new FileInfo(inputFile);
		SplitFile(inputFile, outputDir, fi.Name, GetSizeInBytes(chunkSize, chunkSizeTyp), new KsSplitJoinHandler());
	}
	public static void SplitFile(string inputFile, string outputDir, long chunkSizeInBytes, KsSplitJoinHandler handler) {
		FileInfo fi=new FileInfo(inputFile);
		SplitFile(inputFile, outputDir, fi.Name, chunkSizeInBytes, handler);
	}
	public static void SplitFile(string inputFile, string outputDir, string outputPrefix, long chunkSize, chunkSizeType chunkSizeTyp, KsSplitJoinHandler handler) {
		SplitFile(inputFile, outputDir, outputPrefix, GetSizeInBytes(chunkSize, chunkSizeTyp), handler);
	}
	public static void SplitFile(string inputFile, string outputDir, long chunkSize, chunkSizeType chunkSizeTyp, KsSplitJoinHandler handler) {
		FileInfo fi=new FileInfo(inputFile);
		SplitFile(inputFile, outputDir, fi.Name, GetSizeInBytes(chunkSize, chunkSizeTyp), handler);
	}
	public static void SplitFile(string inputFile, string outputDir, string outputPrefix, long chunkSizeInBytes) {
		SplitFile(inputFile, outputDir, outputPrefix, chunkSizeInBytes, new KsSplitJoinHandler());
	}
	public static void SplitFile(string inputFile, string outputDir, string outputPrefix, long chunkSizeInBytes, KsSplitJoinHandler handler) {
		string outputFile="";
		if(!outputDir.EndsWith("\\")) outputDir+="\\";

		FileInfo fInfo=new FileInfo(inputFile);
		long i, iLen=fInfo.Length, pos=0, len, cnt=0, cnt2, rwIncrament=500000;
		FileStream ifs=new FileStream(inputFile, FileMode.Open, FileAccess.Read);
		BinaryReader reader=new BinaryReader(ifs);
		
		while (pos<iLen) {
			cnt++;
			outputFile=outputDir+outputPrefix+".ksChunk"+cnt.ToString().PadLeft(3, '0');
			FileStream ofs=new FileStream(outputFile, FileMode.Create);
			BinaryWriter writer=new BinaryWriter(ofs);
			len=chunkSizeInBytes;
			if(pos<1) len-=200;
			if((pos+len)>iLen) len=(iLen-pos);
			
			i=0;
			while(i<len) {
				cnt2=rwIncrament;
				if((i+cnt2)>=len) cnt2=len-i;
				writer.Write(reader.ReadBytes((int)cnt2));
				i+=cnt2;
				pos+=cnt2;
				if(!handler.OnUpdate(inputFile, outputFile, pos, iLen)) {
					reader.Close(); ifs.Close();
					writer.Close(); ofs.Close();
					handler.OnCanceled(inputFile, outputFile, pos, iLen);
					return;
				}
			}
			
			writer.Close();
			ofs.Close();
			if(!handler.OnUpdate(inputFile, outputFile, pos, iLen)) {
				reader.Close(); ifs.Close();
				handler.OnCanceled(inputFile, outputFile, pos, iLen);
				return;
			}
			
		}
	
		reader.Close(); ifs.Close();
		SaveAutoJoinFile(outputDir+outputPrefix+".ksAutoJoin", (int)cnt, (int)iLen);

		handler.OnFinished(inputFile, outputFile, pos, iLen);
	}

	public static void SaveAutoJoinFile(string outputFile, int chunkCount, int len) {
		FileMode fm=FileMode.Create;
		FileInfo finfo=new FileInfo(outputFile);
		if(finfo.Exists) fm=FileMode.Truncate;
		FileStream oofs=new FileStream(outputFile, fm);
		StreamWriter wwriter=new StreamWriter(oofs);
		wwriter.WriteLine(chunkCount);
		wwriter.WriteLine(len);
		wwriter.WriteLine(finfo.Name.Substring(0, finfo.Name.Length-finfo.Extension.Length));
		wwriter.Close(); oofs.Close();
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
