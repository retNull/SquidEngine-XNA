﻿#if XNATOUCH
using XnaTouch.Framework;
using XnaTouch.Framework.Audio;
using XnaTouch.Framework.Content;
using XnaTouch.Framework.GamerServices;
using XnaTouch.Framework.Graphics;
using XnaTouch.Framework.Input;
using XnaTouch.Framework.Media;
using XnaTouch.Framework.Net;
using XnaTouch.Framework.Storage;
#else
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
#endif

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SquidEngine.Components;
using System.Xml.Serialization;
using System.Xml;
using System.Reflection;
using SquidEngine.Attributes;
using SquidEngine.SceneItems;

namespace SquidEngine.SceneItems
{
    public class TemplateLinkedItem : SceneItem
    {
        #region Properties

        String TemplateName { get; set; }
        AssetScope TemplateScope { get; set; }

        #endregion
    }
}
