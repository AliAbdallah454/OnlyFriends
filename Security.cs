namespace OnlyFriends {
	internal class Security {

		static string Encrypt(string plaintext, int shift) {
			char[] encryptedChars = new char[plaintext.Length];

			for (int i = 0; i < plaintext.Length; i++) {
				if (char.IsLetter(plaintext[i])) {
					char baseChar = char.IsUpper(plaintext[i]) ? 'A' : 'a';
					encryptedChars[i] = (char)((plaintext[i] - baseChar + shift) % 26 + baseChar);
				}
				else {
					encryptedChars[i] = plaintext[i];
				}
			}

			return new string(encryptedChars);
		}

		static string Decrypt(string ciphertext, int shift) {
			return Encrypt(ciphertext, -shift);
		}
	}


}
