// Copyright © Tom Esendam and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/PortAudio/portaudio/tree/master/include
// Original source is Copyright © 1999-2011 Ross Bencina and Phil Burk. See Notice.md in the repository root for more information.
namespace PortAudioCSharp.Interop
{
    public partial struct PaStreamCallbackTimeInfo
    {
        [NativeTypeName("PaTime")]
        public double inputBufferAdcTime;

        [NativeTypeName("PaTime")]
        public double currentTime;

        [NativeTypeName("PaTime")]
        public double outputBufferDacTime;
    }
}