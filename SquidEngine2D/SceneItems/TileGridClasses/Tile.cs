#if XNATOUCH
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

namespace SquidEngine.SceneItems.TileGridClasses
{
    public struct Tile
    {
        #region Fields

        private byte _rotation;
        private bool _passable;
        private bool _hFlip;
        private bool _vFlip;
        private int _index;
        private bool _collisionMask;
        //private FarseerEntity _farseerEntity;

        #endregion

        public Tile(int index)
        {
            _rotation = 0;
            _passable = true;
            _hFlip = false;
            _vFlip = false;
            _index = index;
            _collisionMask = false;
            //_farseerEntity = null;
        }

        #region Properties

        public byte Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }

        public bool HFlip
        {
            get { return _hFlip; }
            set { _hFlip = value; }
        }

        public bool VFlip
        {
            get { return _vFlip; }
            set { _vFlip = value; }
        }

        public bool Passable
        {
            get { return _passable; }
            set { _passable = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public bool CollisionMask
        {
            get { return _collisionMask; }
            set { _collisionMask = value; }
        }

        /*
        public Farseer.FarseerEntity FarseerEntity
        {
            get { return _farseerEntity; }
            set { _farseerEntity = value; }
        }*/

        #endregion

        #region Methods

        public override string ToString()
        {
            return "{Index: " + _index + " Passable: " + _passable + " Rotation: " + _rotation 
                + " HFlip: " + _hFlip + " VFlip: " + _vFlip + "}";
        } 

        #endregion
    }
}
