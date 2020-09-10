﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEditorLogParser.Parser
{
    public class SupportedExtensions
    {
        HashSet<string> mSupportedExtensions;
        Dictionary<string, string> mCategorizedExtensions;

        public SupportedExtensions()
        {
            mSupportedExtensions = new HashSet<string>()
            {
                ".3ds",
                ".jpg",
                ".jpeg",
                ".tif",
                ".tiff",
                ".tga",
                ".gif",
                ".png",
                ".psd",
                ".bmp",
                ".iff",
                ".pict",
                ".pic",
                ".pct",
                ".exr",
                ".hdr",
                ".cginc",
                ".cg",
                ".glslinc",
                ".hlsl",
                ".shader",
                ".compute",
                ".ogg",
                ".aif",
                ".aiff",
                ".flac",
                ".wav",
                ".mp3",
                ".mod",
                ".it",
                ".s3m",
                ".xm",
                ".rsp",
                ".unity",
                ".txt",
                ".html",
                ".htm",
                ".xml",
                ".json",
                ".csv",
                ".yaml",
                ".bytes",
                ".fnt",
                ".manifest",
                ".md",
                ".js",
                ".boo",
                ".rsp",
                ".anim",
                ".animset",
                ".asset",
                ".blendtree",
                ".buildreport",
                ".colors",
                ".controller",
                ".cubemap",
                ".curves",
                ".curvesNormalized",
                ".flare",
                ".fontsettings",
                ".giparams",
                ".gradients",
                ".guiskin",
                ".ht",
                ".mask",
                ".mat",
                ".mesh",
                ".mixer",
                ".overrideController",
                ".particleCurves",
                ".particleCurvesSigned",
                ".particleDoubleCurves",
                ".particleDoubleCurvesSigned",
                ".physicMaterial",
                ".physicsMaterial2D",
                ".playable",
                ".preset",
                ".renderTexture",
                ".shadervariants",
                ".spriteatlas",
                ".state",
                ".statemachine",
                ".texture2D",
                ".transition",
                ".webCamTexture",
                ".brush",
                ".terrainlayer",
                ".signal",
                ".fbx",
                ".mb",
                ".ma",
                ".max",
                ".jas",
                ".dae",
                ".dxf",
                ".obj",
                ".c4d",
                ".blend",
                ".lxo",
                ".ttf",
                ".dfont",
                ".otf",
                ".ttc",
                ".dll",
                ".winmd",
                ".so",
                ".jar",
                ".java",
                ".kt",
                ".aar",
                ".suprx",
                ".prx",
                ".rpl",
                ".cpp",
                ".cc",
                ".c",
                ".h",
                ".jslib",
                ".jspre",
                ".bc",
                ".a",
                ".m",
                ".mm",
                ".swift",
                ".xib",
                ".bundle",
                ".dylib",
                ".config",
                ".astc",
                ".dds",
                ".ktx",
                ".pvr",
                ".spm",
                ".st",
                ".sbsar",
                ".skp",
                ".avi",
                ".asf",
                ".wmv",
                ".mov",
                ".dv",
                ".mp4",
                ".m4v",
                ".mpg",
                ".mpeg",
                ".ogv",
                ".vp8",
                ".webm",
                ".asmref",
                ".prefab",
                ".raytrace",
                ".po",
                ".asmdef",
                ".cs",
                ".json",
                ".vfx",
                ".vfxoperator",
                ".vfxblock ",
                ".info",
                ".shadergraph",
                ".uxml",
                ".uss"
            };

            mCategorizedExtensions = new Dictionary<string, string>()
            {
                {".3ds", "Texture"},
                {".jpg", "Texture"},
                {".jpeg", "Texture"},
                {".tif", "Texture"},
                {".tiff", "Texture"},
                {".tga", "Texture"},
                {".gif", "Texture"},
                {".png", "Texture"},
                {".psd", "Texture"},
                {".bmp", "Texture"},
                {".iff", "Texture"},
                {".pict", "Texture"},
                {".pic", "Texture"},
                {".pct", "Texture"},
                {".exr", "Texture"},
                {".hdr", "Texture"},
                {".cginc", "Shader"},
                {".cg", "Shader"},
                {".glslinc", "Shader"},
                {".hlsl", "Shader"},
                {".shader", "Shader"},
                {".compute", "ComputeShader"},
                {".ogg", "Audio"},
                {".aif", "Audio"},
                {".aiff", "Audio"},
                {".flac", "Audio"},
                {".wav", "Audio"},
                {".mp3", "Audio"},
                {".mod", "Audio"},
                {".it", "Audio"},
                {".s3m", "Audio"},
                {".xm", "Audio"},
                {".rsp", "Script"},
                {".unity", "SerializedAsset"},
                {".txt", "Text"},
                {".html", "Text"},
                {".htm", "Text"},
                {".xml", "Text"},
                {".json", "Text"},
                {".csv", "Text"},
                {".yaml", "Text"},
                {".bytes", "Text"},
                {".fnt", "Text"},
                {".manifest", "Text"},
                {".md", "Text"},
                {".js", "Text"},
                {".boo", "Text"},
                {".anim", "SerializedAsset"},
                {".animset", "SerializedAsset"},
                {".asset", "SerializedAsset"},
                {".blendtree", "SerializedAsset"},
                {".buildreport", "SerializedAsset"},
                {".colors", "SerializedAsset"},
                {".controller", "SerializedAsset"},
                {".cubemap", "SerializedAsset"},
                {".curves", "SerializedAsset"},
                {".curvesNormalized", "SerializedAsset"},
                {".flare", "SerializedAsset"},
                {".fontsettings", "SerializedAsset"},
                {".giparams", "SerializedAsset"},
                {".gradients", ""},
                {".guiskin", "SerializedAsset"},
                {".ht", "SerializedAsset"},
                {".mask", "SerializedAsset"},
                {".mat", "Material"},
                {".mesh", "SerializedAsset"},
                {".mixer", "SerializedAsset"},
                {".overrideController", "SerializedAsset"},
                {".particleCurves", "SerializedAsset"},
                {".particleCurvesSigned", "SerializedAsset"},
                {".particleDoubleCurves", "SerializedAsset"},
                {".particleDoubleCurvesSigned", "SerializedAsset"},
                {".physicMaterial", "SerializedAsset"},
                {".physicsMaterial2D", "SerializedAsset"},
                {".playable", "SerializedAsset"},
                {".preset", "SerializedAsset"},
                {".renderTexture", "SerializedAsset"},
                {".shadervariants", "SerializedAsset"},
                {".spriteatlas", "SerializedAsset"},
                {".state", "SerializedAsset"},
                {".statemachine", "SerializedAsset"},
                {".texture2D", "SerializedAsset"},
                {".transition", "SerializedAsset"},
                {".webCamTexture", "SerializedAsset"},
                {".brush", "SerializedAsset"},
                {".terrainlayer", "SerializedAsset"},
                {".signal", "SerializedAsset"},
                {".fbx", "Model"},
                {".mb", "Model"},
                {".ma", "Model"},
                {".max", "Model"},
                {".jas", "Model"},
                {".dae", "Model"},
                {".dxf", "Model"},
                {".obj", "Model"},
                {".c4d", "Model"},
                {".blend", "Model"},
                {".lxo", "Model"},
                {".ttf", "Font"},
                {".dfont", "Font"},
                {".otf", "Font"},
                {".ttc", "Font"},
                {".dll", "Plugin"},
                {".winmd", "Plugin"},
                {".so", "Plugin"},
                {".jar", "Plugin"},
                {".java", "Plugin"},
                {".kt", "Plugin"},
                {".aar", "Plugin"},
                {".suprx", "Plugin"},
                {".prx", "Plugin"},
                {".rpl", "Plugin"},
                {".cpp", "Plugin"},
                {".cc", "Plugin"},
                {".c", "Plugin"},
                {".h", "Plugin"},
                {".jslib", "Plugin"},
                {".jspre", "Plugin"},
                {".bc", "Plugin"},
                {".a", "Plugin"},
                {".m", "Plugin"},
                {".mm", "Plugin"},
                {".swift", "Plugin"},
                {".xib", "Plugin"},
                {".bundle", "Plugin"},
                {".dylib", "Plugin"},
                {".config", "Plugin"},
                {".astc", "Texture"},
                {".dds", "Texture"},
                {".ktx", "Texture"},
                {".pvr", "Texture"},
                {".spm", "SpeedTree"},
                {".st", "SpeedTree"},
                {".sbsar", "SpeedTree"},
                {".skp", "SpeedTree"},
                {".avi", "Video"},
                {".asf", "Video"},
                {".wmv", "Video"},
                {".mov", "Video"},
                {".dv", "Video"},
                {".mp4", "Video"},
                {".m4v", "Video"},
                {".mpg", "Video"},
                {".mpeg", "Video"},
                {".ogv", "Video"},
                {".vp8", "Video"},
                {".webm", "Video"},
                {".asmref", "Script"},
                {".cs", "Script"},
                {".prefab", "Prefab"},
                {".raytrace", "Raytrace"},
                {".po", "Localization"},
                {".asmdef", "Script"},
                {".vfx", "VFX"},
                {".vfxoperator", "VFX"},
                {".vfxblock" , "VFX"},
                {".info" , "preview"},
                {".shadergraph" , "shadergraph"},
                {".uxml" , "UXML"},
                {".uss" , "USS"}
            };
        }

        public string GetCategory(string extension)
        {
            if (mCategorizedExtensions.ContainsKey(extension.ToLower()))
                return mCategorizedExtensions[extension];

            return extension;
        }

        public HashSet<string> GetSupportedExtensions()
        {
            return mSupportedExtensions;
        }
    }
}