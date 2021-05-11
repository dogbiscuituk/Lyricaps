namespace Lyricaps.Types
{
    using System;

    /// <summary>
    /// Supported subtitle and closed caption files - basic file formats - from YouTube Help
    /// 
    /// A subtitle or closed caption file contains the text of what is said in the video.It also contains time codes for when each line of text should be displayed. 
    /// Some files also include position and style info, which is especially useful for deaf or hard-of-hearing viewers. See what file formats YouTube supports below.
    /// </summary>
    [Flags]
    internal enum CaptionFormats
    {
        None = 0x00,

        /// <summary>
        /// Only basic versions of these files are supported. No style info (markup) is recognised. The file must be in plain UTF-8.
        /// File extension: .srt
        /// </summary>
        SubRip = 0x01,

        /// <summary>
        /// Only basic versions of these files are supported. No style info (markup) is recognised. The file must be in plain UTF-8.
        /// File extension: .sbv or .sub
        /// </summary>
        SubViewer = 0x02,

        /// <summary>
        /// 'FORMAT=' parameter is supported.
        /// File extension: .mpsub
        /// </summary>
        MPsub = 0x04,

        /// <summary>
        /// No style info (markup) is recognised, but enhanced format is supported.
        /// File extension: .lrc
        /// </summary>
        LRC = 0x08,

        /// <summary>
        /// This file type is primarily used for Japanese subtitles.
        /// File extension: .cap
        /// </summary>
        VideotronLambda = 0x10,
    }
}
