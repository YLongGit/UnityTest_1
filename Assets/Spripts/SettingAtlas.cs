using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.U2D;

public class SettingAtlas : AssetPostprocessor
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="assetPath"></param>
    void OnPostprocessTexture(Texture2D texture,string assetPath)
    {
        string AtlasName = new DirectoryInfo(Path.GetDirectoryName(assetPath)).Name;
        TextureImporter textureImporter = assetImporter as TextureImporter;
        textureImporter.textureType = TextureImporterType.Sprite;
        textureImporter.spritePackingTag = AtlasName;
        textureImporter.mipmapEnabled = false;
    }
}
