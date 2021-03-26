using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/iflytek/speech/aidl",
						"com/iflytek/speech",
					},
					new Converter<string, Type>[]{
						lookup_com_iflytek_speech_aidl_package,
						lookup_com_iflytek_speech_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_iflytek_speech_aidl_mappings;
		static Type lookup_com_iflytek_speech_aidl_package (string klass)
		{
			if (package_com_iflytek_speech_aidl_mappings == null) {
				package_com_iflytek_speech_aidl_mappings = new string[]{
					"com/iflytek/speech/aidl/ISpeakerVerifier$Default:Com.Iflytek.Speech.Aidl.SpeakerVerifierDefault",
					"com/iflytek/speech/aidl/ISpeakerVerifier$Stub:Com.Iflytek.Speech.Aidl.SpeakerVerifierStub",
					"com/iflytek/speech/aidl/ISpeechRecognizer$Default:Com.Iflytek.Speech.Aidl.SpeechRecognizerDefault",
					"com/iflytek/speech/aidl/ISpeechRecognizer$Stub:Com.Iflytek.Speech.Aidl.SpeechRecognizerStub",
					"com/iflytek/speech/aidl/ISpeechSynthesizer$Default:Com.Iflytek.Speech.Aidl.SpeechSynthesizerDefault",
					"com/iflytek/speech/aidl/ISpeechSynthesizer$Stub:Com.Iflytek.Speech.Aidl.SpeechSynthesizerStub",
					"com/iflytek/speech/aidl/ISpeechUnderstander$Default:Com.Iflytek.Speech.Aidl.SpeechUnderstanderDefault",
					"com/iflytek/speech/aidl/ISpeechUnderstander$Stub:Com.Iflytek.Speech.Aidl.SpeechUnderstanderStub",
					"com/iflytek/speech/aidl/ITextUnderstander$Default:Com.Iflytek.Speech.Aidl.TextUnderstanderDefault",
					"com/iflytek/speech/aidl/ITextUnderstander$Stub:Com.Iflytek.Speech.Aidl.TextUnderstanderStub",
					"com/iflytek/speech/aidl/IWakeuper$Default:Com.Iflytek.Speech.Aidl.WakeuperDefault",
					"com/iflytek/speech/aidl/IWakeuper$Stub:Com.Iflytek.Speech.Aidl.WakeuperStub",
				};
			}

			return Lookup (package_com_iflytek_speech_aidl_mappings, klass);
		}

		static string[] package_com_iflytek_speech_mappings;
		static Type lookup_com_iflytek_speech_package (string klass)
		{
			if (package_com_iflytek_speech_mappings == null) {
				package_com_iflytek_speech_mappings = new string[]{
					"com/iflytek/speech/GrammarListener$Default:Com.Iflytek.Speech.GrammarListenerDefault",
					"com/iflytek/speech/GrammarListener$Stub:Com.Iflytek.Speech.GrammarListenerStub",
					"com/iflytek/speech/LexiconListener$Default:Com.Iflytek.Speech.LexiconListenerDefault",
					"com/iflytek/speech/LexiconListener$Stub:Com.Iflytek.Speech.LexiconListenerStub",
					"com/iflytek/speech/RecognizerListener$Default:Com.Iflytek.Speech.RecognizerListenerDefault",
					"com/iflytek/speech/RecognizerListener$Stub:Com.Iflytek.Speech.RecognizerListenerStub",
					"com/iflytek/speech/SpeechUnderstanderListener$Default:Com.Iflytek.Speech.SpeechUnderstanderListenerDefault",
					"com/iflytek/speech/SpeechUnderstanderListener$Stub:Com.Iflytek.Speech.SpeechUnderstanderListenerStub",
					"com/iflytek/speech/SynthesizerListener$Default:Com.Iflytek.Speech.SynthesizerListenerDefault",
					"com/iflytek/speech/SynthesizerListener$Stub:Com.Iflytek.Speech.SynthesizerListenerStub",
					"com/iflytek/speech/SynthesizeToUrlListener$Default:Com.Iflytek.Speech.SynthesizeToUrlListenerDefault",
					"com/iflytek/speech/SynthesizeToUrlListener$Stub:Com.Iflytek.Speech.SynthesizeToUrlListenerStub",
					"com/iflytek/speech/TextUnderstanderListener$Default:Com.Iflytek.Speech.TextUnderstanderListenerDefault",
					"com/iflytek/speech/TextUnderstanderListener$Stub:Com.Iflytek.Speech.TextUnderstanderListenerStub",
					"com/iflytek/speech/VerifierListener$Default:Com.Iflytek.Speech.VerifierListenerDefault",
					"com/iflytek/speech/VerifierListener$Stub:Com.Iflytek.Speech.VerifierListenerStub",
					"com/iflytek/speech/WakeuperListener$Default:Com.Iflytek.Speech.WakeuperListenerDefault",
					"com/iflytek/speech/WakeuperListener$Stub:Com.Iflytek.Speech.WakeuperListenerStub",
				};
			}

			return Lookup (package_com_iflytek_speech_mappings, klass);
		}
	}
}
