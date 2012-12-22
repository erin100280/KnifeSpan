/* User: Erin
 * Date: 12/12/2012
 * Time: 6:27 AM
 */
using System;
using System.IO;

public class KsSplitJoinHandler {
	public virtual void OnCanceled(string srcFile, string tgtFile, long curPos, long total) {
		this.OnCanceled(srcFile, tgtFile, curPos, total, -20, -20);
	}
	public virtual void OnCanceled(string srcFile, string tgtFile, long curPos, long total, int chunkNum, int chunkCount) {}
	public virtual void OnFinished(string srcFile, string tgtFile, long curPos, long total) {
		this.OnFinished(srcFile, tgtFile, curPos, total, -20, -20);
	}
	public virtual void OnFinished(string srcFile, string tgtFile, long curPos, long total, int chunkNum, int chunkCount) {}
	public virtual bool OnUpdate(string srcFile, string tgtFile, long curPos, long total) {
		return this.OnUpdate(srcFile, tgtFile, curPos, total, -20, -20);
	}
	public virtual bool OnUpdate(string srcFile, string tgtFile, long curPos, long total, int chunkNum, int chunkCount) { return true; }
}

public class KsJoiner {
	public static void JoinFile(string inputFile, string outputFile, KsSplitJoinHandler handler) {
		long rwIncrament=500000;//updateInterval=400000, updateIndex=0;
		FileInfo fInfo=new FileInfo(inputFile);
		long iLen=fInfo.Length;
		FileStream ifs=new FileStream(inputFile, FileMode.Open);
		BinaryReader reader=new BinaryReader(ifs);
		//bool cont;
		
		FileInfo fi=new FileInfo(outputFile);
		FileMode fm=FileMode.Append;
		if(!fi.Exists) fm=FileMode.CreateNew;
		FileStream ofs=new FileStream(outputFile, fm);
		BinaryWriter writer=new BinaryWriter(ofs);
		
		long i=0, cnt;
		while(i<iLen) {
			cnt=rwIncrament;
			if((i+cnt)>=iLen) cnt=iLen-i;
			//byte val[cnt];
			writer.Write(reader.ReadBytes((int)cnt));
			i+=cnt;
			if(!handler.OnUpdate(inputFile, outputFile, i, iLen)) {
				ifs.Close(); reader.Close();
				ofs.Close(); writer.Close();
				handler.OnCanceled(inputFile, outputFile, i, iLen);
				return;
			}
		}
		
		ifs.Close(); reader.Close();
		ofs.Close(); writer.Close();
		handler.OnFinished(inputFile, outputFile, i, iLen);
	}
}

