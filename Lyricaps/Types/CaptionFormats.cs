namespace Lyricaps.Types
{
    using System;

    /// <summary>
    /// Supported subtitle and closed caption files - basic, advanced, and broadcast file formats - from YouTube Help
    /// 
    /// A subtitle or closed caption file contains the text of what is said in the video.
    /// It also contains time codes for when each line of text should be displayed. 
    /// Some files also include position and style info, which is especially useful for deaf or hard-of-hearing viewers.
    /// See what file formats YouTube supports below.
    /// </summary>
    [Flags]
    internal enum CaptionFormats
    {
        None = 0,

        /// <summary>
        /// Only basic versions of these files are supported. No style info (markup) is recognised. The file must be in plain UTF-8.
        /// File extension: .srt
        /// </summary>
        SubRip = 1,

        /// <summary>
        /// Only basic versions of these files are supported. No style info (markup) is recognised. The file must be in plain UTF-8.
        /// File extension: .sbv or .sub
        /// </summary>
        SubViewer = 2,

        /// <summary>
        /// 'FORMAT=' parameter is supported.
        /// File extension: .mpsub
        /// </summary>
        MPsub = 4,

        /// <summary>
        /// No style info (markup) is recognised, but enhanced format is supported.
        /// File extension: .lrc
        /// </summary>
        LRC = 8,

        /// <summary>
        /// This file type is primarily used for Japanese subtitles.
        /// File extension: .cap
        /// </summary>
        VideotronLambda = 0x10,

        /// <summary>
        /// Synchronised Accessible Media Interchange
        /// Only timecodes, text and simple markup (<b>, <i>, <u> and the color = attribute within a <font>) are supported. Positioning is not supported.
        /// File extension: .smi or .sami
        /// </summary>
        SAMI = 0x20,

        /// <summary>
        /// Only timecodes, text and simple markup (<b>, <i>, <u> and the color = attribute within a <font>) are supported. Positioning is not supported.
        /// File extension: .rt
        /// </summary>
        RealText = 0x40,

        /// <summary>
        /// In initial implementation. Positioning is supported, but styling is limited to <b>, <i>, <u> since CSS class names are not yet standardised.
        /// File extension: .vtt
        /// </summary>
        WebVTT = 0x80,

        /// <summary>
        /// Timed-Text Markup Language
        /// In partial implementation. SMPTE-TT extensions supported for CEA-608 features.
        /// iTunes Timed Text (iTT) file format is supported; iTT is a subset of TTML, Version 1.0. Styling and positioning are supported.
        /// File extension: .ttml
        /// </summary>
        TTML = 0x100,

        /// <summary>
        /// Distribution Format Exchange Profile
        /// These files types are interpreted as TTML files. 
        /// File extension: .ttml or .dfxp
        /// </summary>
        DFXP = 0x200,

        /// <summary>
        /// These files have an exact representation of CEA-608 data, which is the preferred format whenever captions are based on CEA-608 features.
        /// File extension: .scc
        /// </summary>
        ScenaristClosedCaption = 0x400,

        /// <summary>
        /// European Broadcasting Union standard.
        /// File extension: .stl
        /// </summary>
        EBU_STL_binary = 0x800,

        /// <summary>
        /// Supports CEA-608 features.
        /// File extension: .tds
        /// </summary>
        CaptionCenter_binary = 0x1000,

        /// <summary>
        /// Supports CEA-608 features.
        /// File extension: .cin
        /// </summary>
        CaptionsInc_binary = 0x2000,

        /// <summary>
        /// Supports CEA-608 features.
        /// File extension: .asc
        /// </summary>
        Cheetah_ASCII = 0x4000,

        /// <summary>
        /// Supports CEA-608 features.
        /// File extension: .cap
        /// </summary>
        Cheetah_binary = 0x8000,

        /// <summary>
        /// Supports CEA-608 features.
        /// File extension: .cap
        /// </summary>
        NCI_binary = 0x10000,

        Basic = SubRip | SubViewer | MPsub | LRC | VideotronLambda,
        Advanced = SAMI | RealText | WebVTT | TTML | DFXP,
        Broadcast = ScenaristClosedCaption | EBU_STL_binary | CaptionCenter_binary | CaptionsInc_binary | Cheetah_ASCII | Cheetah_binary | NCI_binary,
        All = Basic | Advanced | Broadcast,
    }
}
