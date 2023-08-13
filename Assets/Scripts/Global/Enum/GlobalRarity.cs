using UnityEngine;

public class GlobalRarity : MonoBehaviour
{
    public enum Rarity
    {
        NORMAL = 0, // Обычная
        RARE = 1, // Редкая
        MAGIC = 2, // Магическая
        LEGENDARY = 3 // Легендарная
    }

    [SerializeField] private Sprite _normalCard;
    [SerializeField] private Sprite _rareCard;
    [SerializeField] private Sprite _magicCard;
    [SerializeField] private Sprite _legendaryCard;
    
    [SerializeField] private Sprite _normalMini;
    [SerializeField] private Sprite _rareMini;
    [SerializeField] private Sprite _magicMini;
    [SerializeField] private Sprite _legendaryMini;

    public Sprite GetRarityCardSprite(Rarity m_rarity)
    {
        if (!_normalCard || !_rareCard || !_magicCard || !_legendaryCard) return null;

        switch (m_rarity)
        {
            case Rarity.NORMAL:
                return _normalCard;
            case Rarity.RARE:
                return _rareCard;
            case Rarity.MAGIC:
                return _magicCard;
            case Rarity.LEGENDARY:
                return _legendaryCard;

            default: 
                Debug.LogError("This rarity is not found. Set default = NORMAL (_normalCard)");
                return _normalCard; 
        }
    }

    public Sprite GetRarityMiniSprite(Rarity m_rarity)
    {
        if (!_normalMini || !_rareMini || !_magicMini || !_legendaryMini) return null;

        switch (m_rarity)
        {
            case Rarity.NORMAL:
                return _normalMini;
            case Rarity.RARE:
                return _rareMini;
            case Rarity.MAGIC:
                return _magicMini;
            case Rarity.LEGENDARY:
                return _legendaryMini;

            default: 
                Debug.LogError("This rarity is not found. Set default = NORMAL (_legendaryMini)");
                return _normalMini; 
        }
    }

    public string GetRarityText(Rarity m_rarity)
    {
        switch (m_rarity)
        {
            case Rarity.NORMAL:
                return "Normal";
            case Rarity.RARE:
                return "Rare";
            case Rarity.MAGIC:
                return "Magic";
            case Rarity.LEGENDARY:
                return "Legendary";

            default: 
                Debug.LogError("This rarity is not found. Set default = NORMAL (_legendaryMini)");
                return "Normal";
        }
    }

    public float GetUpgradePriceMultiply(Rarity m_rarity)
    {
        switch (m_rarity)
        {
            case Rarity.NORMAL:
                return 1.5f;
            case Rarity.RARE:
                return 2f;
            case Rarity.MAGIC:
                return 2.5f;
            case Rarity.LEGENDARY:
                return 3f;

            default: 
                Debug.LogError("This rarity is not found. Set default = NORMAL (1.5f)");
                return 1.5f;
        }
    }

    public int GetMaxLevelUpgrade(Rarity m_rarity)
    {
        switch (m_rarity)
        {
            case Rarity.NORMAL:
                return 40;
            case Rarity.RARE:
                return 24;
            case Rarity.MAGIC:
                return 12;
            case Rarity.LEGENDARY:
                return 5;

            default: 
                Debug.LogError("This rarity is not found. Set default = NORMAL (40)");
                return 40;
        }
    }
}
