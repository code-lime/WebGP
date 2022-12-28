﻿using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace WebGP.Domain.Helpers.MinecraftParser.Models
{
    public class Head : ImageProjections
    {
        private const int SIDE_SIZE = 8;

        public Head(Image<Rgba32> image)
            : base (image)
        {
        }

        public override void ParseAll()
        {
            throw new NotImplementedException();
        }

        public override void ParseAllBase()
        {
            ParseBack();
            ParseFront();
            ParseLeft();
            ParseRight();
            ParseTop();
            ParseBot();
        }

        public override void ParseBack()
        {
            throw new NotImplementedException();
        }

        public override void ParseBackBase()
        {
            var tmp = new Image<Rgba32>(SIDE_SIZE, SIDE_SIZE);
            parseHeadBaseProjection(ref tmp, SIDE_SIZE * 3, SIDE_SIZE, SIDE_SIZE, SIDE_SIZE);
            Back = tmp;
        }

        public override void ParseBot()
        {
            throw new NotImplementedException();
        }

        public override void ParseBotBase()
        {
            var tmp = new Image<Rgba32>(SIDE_SIZE, SIDE_SIZE);
            parseHeadBaseProjection(ref tmp, SIDE_SIZE * 2, 0, SIDE_SIZE, SIDE_SIZE);
            Bot = tmp;
        }

        public override void ParseFront()
        {
            throw new NotImplementedException();
        }

        public override void ParseFrontBase()
        {
            var tmp = new Image<Rgba32>(SIDE_SIZE, SIDE_SIZE);
            parseHeadBaseProjection(ref tmp, SIDE_SIZE, SIDE_SIZE, SIDE_SIZE, SIDE_SIZE);
            Front = tmp;
        }

        public override void ParseLeft()
        {
            throw new NotImplementedException();
        }

        public override void ParseLeftBase()
        {
            var tmp = new Image<Rgba32>(SIDE_SIZE, SIDE_SIZE);
            parseHeadBaseProjection(ref tmp, SIDE_SIZE * 2, SIDE_SIZE, SIDE_SIZE, SIDE_SIZE);
            Left = tmp;
        }

        public override void ParseRight()
        {
            throw new NotImplementedException();
        }

        public override void ParseRightBase()
        {
            var tmp = new Image<Rgba32>(SIDE_SIZE, SIDE_SIZE);
            parseHeadBaseProjection(ref tmp, 0, SIDE_SIZE, SIDE_SIZE, SIDE_SIZE);
            Right = tmp;
        }

        public override void ParseTop()
        {
            throw new NotImplementedException();
        }

        public override void ParseTopBase()
        {
            var tmp = new Image<Rgba32>(SIDE_SIZE, SIDE_SIZE);
            parseHeadBaseProjection(ref tmp, SIDE_SIZE, 0, SIDE_SIZE, SIDE_SIZE);
            Top = tmp;
        }
    }
}
