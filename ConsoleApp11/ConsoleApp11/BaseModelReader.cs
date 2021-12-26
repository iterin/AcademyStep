using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Order
{
	public abstract class BaseModelReader : IDisposable
	{
		protected readonly string _fileName;
		private StreamReader _stream;
		public bool IsOpened => _stream != null;

		protected BaseModelReader(string fileName)
		{
			if (string.IsNullOrWhiteSpace(fileName))
				throw new ArgumentNullException(nameof(fileName));
			_fileName = fileName;
		}
		public void Dispose()
		{
			if(_stream != null)
				_stream.Dispose();
		}

		protected void Open()
		{
			_stream = new StreamReader(_fileName);
		}

		protected void Close()
		{
			if (_stream == null)
				throw new NullReferenceException(nameof(_stream));
			_stream.Dispose();
            _stream = null;
           
		}

		protected string ReadLine()
		{
			if (_stream == null)
				throw new ArgumentNullException(nameof(_stream));
			return _stream.ReadLine();
		}
	}
}
