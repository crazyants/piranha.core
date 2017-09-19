/*
 * Copyright (c) 2017 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/piranhacms/piranha
 * 
 */

using System;

namespace Piranha.Data 
{
    public sealed class MediaVersion : IModel, ICreated
    {
        /// <summary>
        /// Gets/sets the unique id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets/sets the media id.
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// Gets/sets the requested width of the image in pixels.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets/sets the requested height of the image in pixels.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Gets/sets the created date.
        /// </summary>
        /// <returns></returns>
        public DateTime Created { get; set; }
    }
}